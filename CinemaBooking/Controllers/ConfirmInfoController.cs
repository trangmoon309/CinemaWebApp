using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaBooking.Models;
using CinemaBooking.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CinemaBooking.Controllers
{
    public class ConfirmInfoController : Controller
    {
        private UserManager<ApplicationUser> userManager { get; set; }
        private SignInManager<ApplicationUser> signInManager { get; set; }
        private readonly ILogger<AccountController> logger;

        public ConfirmInfoController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
                ILogger<AccountController> logger)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult ConfirmEmail(string userId, string token)
        {
            ViewBag.userId = userId;
            ViewBag.token = token;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmEmailHandler(string userId, string token)
        {
            if(userId == null || token == null)
            {
                ViewBag.MessageError = "Id/Token không tồn tại";
                return View("Error");
            }

            var user = await userManager.FindByIdAsync(userId);
            if(user == null)
            {
                ViewBag.MessageError = "User không tồn tại";
                return View("Error");
            }

            var result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                var logIn = await signInManager.PasswordSignInAsync(user.Email, user.PasswordHash, false, false);
                if (logIn.Succeeded)
                {
                    return RedirectToAction("Main", "Home");
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }

            ViewBag.MessageError = "Xác thực email thất bại.";
            return View("Error");
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if(user == null)
                {
                    ModelState.AddModelError(string.Empty, "Người dùng không tồn tại/chưa confirm email!");
                    return View(model);
                }

                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                return RedirectToAction("ResetPasswordConfirmation", "ConfirmInfo", new { email = model.Email, token = token });
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation(string email,string token)
        {
            ResetPasswordConfirmationViewModel model = new ResetPasswordConfirmationViewModel()
            {
                Email = email,
            };
            ViewBag.token = token;
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPasswordConfirmation(ResetPasswordConfirmationViewModel model,string token)
        {
            if (ModelState.IsValid)
            {
                if(model.Email == null || token == null)
                {
                    ViewBag.MessageError = "Email/Token không tồn tại!";
                    return View("Error");
                }

                var user = await userManager.FindByEmailAsync(model.Email);
                if(user == null)
                {
                    ViewBag.MessageError = "Người dùng không tồn tại!";
                    return View("Error");
                }

                var result = await userManager.ResetPasswordAsync(user, token, model.Password);
                if (result.Succeeded)
                {
                    return View("ResetPasswordSuccess");
                }
            }
            return View(model);
        }


    }
}
