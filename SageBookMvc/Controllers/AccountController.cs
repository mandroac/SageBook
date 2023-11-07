using Domain.Constants;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SageBookMvc.Models;

namespace SageBookMvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid credentials");
                    return View(loginModel);
                }
            }
            else
            {
                return View(loginModel);
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerModel)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    Email = registerModel.Email,
                    UserName = registerModel.Email
                };
                var registrationResult = await _userManager.CreateAsync(user, registerModel.Password);
                if (registrationResult.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, AppRoles.User);
                    if (roleResult.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        roleResult.Errors.ToList().ForEach(error => ModelState.AddModelError(error.Code, error.Description));
                        return View(registerModel);
                    }
                }
                else
                {
                    registrationResult.Errors.ToList().ForEach(error => ModelState.AddModelError(error.Code, error.Description));
                    return View(registerModel);
                }
            }
            else
            {
                return View(registerModel);
            }
        }
    }
}
