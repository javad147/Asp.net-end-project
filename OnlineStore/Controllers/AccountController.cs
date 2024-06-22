using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Areas.Identity.Data;
using OnlineStore.Data;
using OnlineStore.Models;
using System.Data;

namespace OnlineStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<OnlineStoreUser> _userManager;
        private readonly SignInManager<OnlineStoreUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly OnlineStoreContext _context;
        public AccountController(UserManager<OnlineStoreUser> userManager,
                                 SignInManager<OnlineStoreUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 OnlineStoreContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        [Authorize(Roles ="SuperAdmin")]
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterVM request)
        {
            if (!ModelState.IsValid) return View(request);
            //Roles  creation
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(nameof(role)))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
                }
            }
            OnlineStoreUser user = new()
            {
                Email = request.Email,
                UserName = request.UserName,
                FullName = request.FullName,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
                return View(request);
            }

            await _userManager.AddToRoleAsync(user, request.RoleName);

            return RedirectToAction("Index", "Admin");

        }


        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginVM request)
        {
            if (!ModelState.IsValid) return View();

            var existUser = await _userManager.FindByEmailAsync(request.EmailOrUsername);

            if (existUser is null)
            {
                existUser = await _userManager.FindByNameAsync(request.EmailOrUsername);
            }

            if (existUser is null)
            {
                ModelState.AddModelError(string.Empty, "Login failed");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(existUser, request.Password, request.IsPresistant, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Login failed");
                return View();
            }

            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



    }
    public enum Roles
    {
        SuperAdmin = 1,
        Admin,
        Member
    }
}
