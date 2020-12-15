using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassDrive.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace ClassDrive.Controllers
{
    public class AccountController : Controller
    {
        private readonly DriveDbContext _context;

        public AccountController(DriveDbContext context)
        {
            _context = context;
        }

        // GET: Account
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccountModel.ToListAsync());
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {

            if (!string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            var userExist = _context.AccountModel.Where(x => x.UserName == username).ToList();
            var getRole = await _context.AccountModel.FirstOrDefaultAsync(m => m.UserName == username);
            var userrole = getRole.UserRole;
            if (userExist.Any(x => x.UserName == username))
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,username),
                    new Claim(ClaimTypes.Role,userrole)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            /* if (username == "admin" && password == "a")
             {
                 identity = new ClaimsIdentity(new[]
                 {
                     new Claim(ClaimTypes.Name,username),
                     new Claim(ClaimTypes.Role,"Admin")
                 }, CookieAuthenticationDefaults.AuthenticationScheme);
                 isAuthenticate = true;
             }
             if (username == "demo" && password == "c")
             {
                 identity = new ClaimsIdentity(new[]
                 {
                     new Claim(ClaimTypes.Name,username),
                     new Claim(ClaimTypes.Role,"User")
                 }, CookieAuthenticationDefaults.AuthenticationScheme);
                 isAuthenticate = true;
             } */
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
