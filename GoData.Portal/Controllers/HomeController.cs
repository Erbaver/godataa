using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Helpers;
using GoData.Portal.Interfaces;
using GoData.Portal.Models;
using GoData.Portal.PageViewModels;
using GoData.Portal.PageViewModels.HomePageViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GoData.Portal.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public HomeController(
            OrganizationLogic organizationLogic,
            UserLogic userLogic)
        {
            _organizationLogic = organizationLogic;
            _userLogic = userLogic;
        }

        public IActionResult Index()
        {
            _viewModel.ActionViewModel = new IndexPageViewModel();
           
            var organizations = _organizationLogic.GetOrganizationsByUserId(userId);

            if (organizations.Count() < 1)
            {
                return RedirectToAction("Create", "Organizations");
            }

            return View(_viewModel);
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
