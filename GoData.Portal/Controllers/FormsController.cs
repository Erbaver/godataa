using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoData.Portal.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GoData.Portal.Controllers
{
    public class FormsController : Controller
    {
      
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FormTemplateDto model)
        {
            return RedirectToAction(nameof(Details));
        }

        public IActionResult Details()
        {
            return View();
        }


    }
}