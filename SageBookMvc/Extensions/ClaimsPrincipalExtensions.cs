﻿using System.Security.Claims;

namespace SageBookMvc.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static Guid GetUserId(this ClaimsPrincipal user)
        {
            var userId = user.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value;
            return Guid.TryParse(userId, out var result) ? result : Guid.Empty;
        }
    }
}
