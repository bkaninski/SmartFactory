using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace SmartFactory.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);

        }
        public static string Role(this ClaimsPrincipal user)
        {
           return user.FindFirstValue(ClaimTypes.Role);

        }
    }
}
