using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CinemaBooking.Models;
using CinemaBooking.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CinemaBooking.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager { get; set; }
        private SignInManager<ApplicationUser> signInManager { get; set; }
        private readonly ILogger<AccountController> logger;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
                ILogger<AccountController> logger)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
        }

        [HttpGet]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailUsed(string email)
        {
            //Thêm attribute Remote cho Email bên RegisterViewModel
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else return Json($"Email {email} đã tồn tại!");
        }

        [HttpGet]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IsUserNameUsed(string username)
        {
            //Thêm attribute Remote cho Email bên RegisterViewModel
            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                return Json(true);
            }
            else return Json($"Tài khoản {username} đã tồn tại!");
        }

        [HttpGet]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailExist(string email)
        {
            //Thêm attribute Remote cho Email bên RegisterViewModel
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json($"Email không tồn tại!");
            }
            else return Json(true);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.IsConfirm)
                {
                    ApplicationUser user = new ApplicationUser()
                    {
                        FullName = model.FirstName + model.LastName,
                        Email = model.Email,
                        PhoneNumber = model.PhoneNumber,
                        UserName = model.UserName,
                        NormalizedUserName = model.UserName,
                    };

                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confirmLink = Url.Action("ConfirmEmail", "ConfirmInfo", new { userId = user.Id, token = token }, Request.Scheme);

                        return RedirectToAction("ConfirmEmail", "ConfirmInfo", new { userId = user.Id, token = token });
                        //return View("Login");
                    }
                    return View("Error");
                }

                ModelState.AddModelError(string.Empty, "Bạn cần chắc chắn xác nhận tuân theo các điều lệ?");
                return View(model);

            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            LoginViewModel model = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Username/Password không tồn tại");
                    return View();
                }

                if (await userManager.CheckPasswordAsync(user, model.Password))
                {
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, isPersistent: model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Main", "Home");
                    }
                }
                ModelState.AddModelError(string.Empty, "Đăng nhập không thành công.");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Main", "Home");
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalCallBack", "Account", new { ReturnUrl = returnUrl });
            var property = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, property);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalCallBack(string ReturnUrl = null, string remoteError = null)
        {
            ReturnUrl = ReturnUrl ?? Url.Content("~/");
            if(remoteError != null)
            {
                ViewBag.MessageError = "Error from external provider!";
                return View("Error");
            }

            LoginViewModel model = new LoginViewModel()
            {
                ReturnUrl = ReturnUrl,
                ExternalLogin =
                        (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            var info = await signInManager.GetExternalLoginInfoAsync();
            if(info == null)
            {
                ViewBag.MessageError = "Không tìm thấy thông tin từ External Provider.";
                return View("Error");
            }

            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            ApplicationUser user = null;
            if(email == null)
            {
                ViewBag.MessageError = "Bạn chưa cung cấp địa chỉ Email cho External Provider, vui lòng cung cấp email trước khi sử dụng" +
                    " chức năng login này";
                return View("Error");
            }

            user = await userManager.FindByEmailAsync(email);

            //Kiểm tra confirm Email trước: user tồn tại nhưng chưa confirm email
            if(user != null && !user.EmailConfirmed)
            {
                ModelState.AddModelError(string.Empty, "Email not confirmed yet!");
                return View("Login", model);
            }

            //Tiếp đến mới kiểm tra login được không?
            //nếu user đã có record trong bảng userlogin thì signin sẽ thành công
            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.LoginProvider, false, false);

            if (signInResult.Succeeded)
            {
                return LocalRedirect(ReturnUrl);
            }
            //user chưa trong trong table userlogin
            else
            {
                if (user == null)
                {
                    user = new ApplicationUser()
                    {
                        UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };

                    var result = await userManager.CreateAsync(user);

                    if (result.Succeeded)
                    {
                        var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        return RedirectToAction("ConfirmEmail", "ConfirmInfo", new { userId = user.Id, token = token });
                    }

                    else
                    {
                        ViewBag.MessageError = "Không thể tạo user mới!";
                        return View("Error");
                    }

                }

                await userManager.AddLoginAsync(user, info);
                await signInManager.SignInAsync(user, isPersistent: false);

                return LocalRedirect(ReturnUrl);
            }
        }


        [HttpGet]
        public async Task<IActionResult> AccountDetail()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser user = await userManager.FindByIdAsync(userID);

            //user đăng nhập = face/gg thì k fullname = null
            if(user.FullName == null)
            {
                user.FullName = "Chưa có tên";
            }
            AccountDetailViewModel model = new AccountDetailViewModel()
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AccountDetail(AccountDetailViewModel model)
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser user = await userManager.FindByIdAsync(userID);

            user.PhoneNumber = model.PhoneNumber;
            user.Email = model.Email;
            user.FullName = model.FullName;
            
            if(model.Password != null)
            {
                var token = await userManager.GeneratePasswordResetTokenAsync(user);

                var result = await userManager.ResetPasswordAsync(user, token, model.Password);
                if (result.Succeeded)
                {
                    ModelState.AddModelError("", "Lưu thành công");

                    return View(model);
                }

                ModelState.AddModelError("", "Đổi mật khẩu không thành công");

                return View(model);
            }

            ModelState.AddModelError("", "Lưu thành công");

            return View(model);
        }   


    }
}
