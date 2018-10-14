using AutoMapper;
using GoData.Core.Logic;
using GoData.Core.Repositories;
using GoData.Entities.Entities;
using GoData.Portal.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GoData.Portal.Controllers
{
    public class OrganizationsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly OrganizationLogic _logic;

        public OrganizationsController(
            IMapper mapper,
            OrganizationLogic logic)
        {
            _mapper = mapper;
            _logic = logic;
        }
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
        public async Task<IActionResult> Create(OrganizationDto model)
        {
            if (ModelState.IsValid)
            {
                
                var organization = _mapper.Map<Organization>(model);

                var res = await _logic.CreateOrganization(organization);


                //goto details action after creating organization
                return RedirectToAction(nameof(Organization), new { res.Id });
            }

            return View();
        }

        [HttpGet]
        public IActionResult Organization(int Id)
        {
            return View();
        }

    }
}