using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Retribusi.Controllers;

public class AuthorizationController : Controller
{
    [HttpGet("~/login")]
    public IActionResult LogIn()
    {
        return Challenge(new AuthenticationProperties { RedirectUri = "/dashboard" }, OpenIdConnectDefaults.AuthenticationScheme);
    }

    [HttpGet("~/logout"), HttpPost("~/logout")]
    public IActionResult LogOut()
    {
        return SignOut(CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
    }
}
