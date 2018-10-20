using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Helpers;
using GoData.Portal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace GoData.Portal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private UserLogic _userLogic;
        private UserHelper _userHelper;
        private Dictionary<string, string>  _userProperties;

        public HomeController(
            UserHelper helper,
            UserLogic userLogic)
        {
            _userLogic = userLogic;
            _userHelper = helper;
        }

        public IActionResult Index()
        {
            _userProperties = _userHelper.GetUserProperties(User);

            var user = _userLogic.GetUserByUserObjectId(_userProperties["ObjectId"]);
            if (user.Organizations.Count < 1)
                return RedirectToAction("Create", nameof(OrganizationsController));

            return View();
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
