using Domain.Constants;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SageBookWebApi.Requests;
using Swashbuckle.AspNetCore.Annotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SageBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("Login")]
        [SwaggerOperation("Sign in using email and password.")]
        public async Task<IActionResult> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByEmailAsync(loginRequest.Email);
            if (user == null)
            {
                return Unauthorized("Invalid login credentials");
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginRequest.Password, false, false);

            if (result.Succeeded)
            {
                var token = await GenerateJwtTokenAsync(user);
                return Ok("Bearer " + token);
            }
            else return Unauthorized("Authentication failed");
        }

        [HttpPost("Register")]
        [SwaggerOperation("Sign up using email and password.")]
        public async Task<IActionResult> RegisterAsync(LoginRequest loginRequest)
        {
            var user = new AppUser
            {
                Email = loginRequest.Email,
                UserName = loginRequest.Email,
                EmailConfirmed = true
            };
            var result = await _userManager.CreateAsync(user, loginRequest.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, AppRoles.User);

                //get created user from db to know its id
                user = await _userManager.FindByEmailAsync(loginRequest.Email);
                var token = await GenerateJwtTokenAsync(user);

                return Ok("Bearer " + token);
            }
            else
            {
                result.Errors.ToList().ForEach(error => ModelState.AddModelError(error.Code, error.Description));
                return BadRequest(ModelState);
            }
        }

        private async Task<string> GenerateJwtTokenAsync(AppUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1), // token valid for 1 hour
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SageBookSecretKey")),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                tokenDescriptor.Subject.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}
