using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAndRegistration.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class Administration : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public Administration(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateRole()
        {
          return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            IdentityRole identityRole = new IdentityRole()
            {
                Name=model.Name
            };
            var result=await _roleManager.CreateAsync(identityRole);
            return View(model);
        }
    }
}
