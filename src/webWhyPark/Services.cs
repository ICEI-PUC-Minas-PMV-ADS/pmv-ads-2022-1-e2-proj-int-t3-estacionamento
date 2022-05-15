using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using webWhyPark.Models;
namespace webWhyPark
{
    public class Services
    {
        public async Task Login(HttpContext ctx, Cliente cliente)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, cliente.Nome));
            claims.Add(new Claim(ClaimTypes.Role, cliente.Cargo));

            var claimsIdentity = new ClaimsPrincipal(
                new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                )
            );

            var AuthProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.Now.AddHours(8),
                IssuedUtc = DateTime.Now
            };

            await ctx.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsIdentity);
        }

        public async Task Logout(HttpContext ctx)
        {
            await ctx.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        }
    }
}