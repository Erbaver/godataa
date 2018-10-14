using GoData.Portal.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GoData.Portal.Controllers
{
    public class OrganizationsController : Controller
    {
        //returns page with all organizations
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get(int Id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(OrganizationDto model)
        {
            if (!ModelState.IsValid)
            {

            }

            return View();
        }

    }
}