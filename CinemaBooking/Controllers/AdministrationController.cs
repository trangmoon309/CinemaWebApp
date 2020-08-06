using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CinemaBooking.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<AdministrationController> logger;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
            ILogger<AdministrationController> logger)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.logger = logger;

        }

        [AllowAnonymous]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            IdentityRole role = new IdentityRole()
            {
                Name = roleName
            };
            await roleManager.CreateAsync(role);
            ViewBag.Noti = "Thành công";

            return View("Noti");
        }

        [AllowAnonymous]
        public async Task<IActionResult> AddAdminToUser(string username)
        {
            var user = await userManager.FindByNameAsync(username);
            var role = await roleManager.FindByNameAsync("Admin");
            await userManager.AddToRoleAsync(user, role.Name);
                ViewBag.Noti = "Thành công";

            return View("Noti");
        }

        //https://localhost:44307/Administration/AddAdminToUser?username=trangmoon309
    }
}
