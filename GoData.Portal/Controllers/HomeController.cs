using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Helpers;
using GoData.Portal.Models;
using GoData.Portal.PageViewModels.HomePageViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GoData.Portal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private UserLogic _userLogic;
        private UserHelper _userHelper;
        private OrganizationLogic _organizationLogic;

        public HomeController(
            UserHelper helper,
            UserLogic userLogic,
            OrganizationLogic organizationLogic)
        {
            _userLogic = userLogic;
            _userHelper = helper;
            _organizationLogic = organizationLogic;
        }

        public IActionResult Index()
        {
            var userId = Int32.Parse(Request.Headers["User"].ToString());

            var model = new IndexPageViewModel(userId, _userLogic);

            

            var organizations = _organizationLogic.GetOrganizationsByUserId(userId);

            if (organizations.Count() < 1)
            {
                return RedirectToAction("Create", "Organizations");
            }

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
