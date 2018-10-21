using AutoMapper;
using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoData.Portal.Controllers
{
    [Authorize]
    public class OrganizationsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly OrganizationLogic _organizationLogic;
        private readonly UserLogic _userLogic;

        public OrganizationsController(
            IMapper mapper,
            OrganizationLogic organizationlogic,
            UserLogic userLogic)
        {
            _mapper = mapper;
            _organizationLogic = organizationlogic;
            _userLogic = userLogic;
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
                //check if user exists

                var organization = _mapper.Map<Organization>(model);
                organization.Units = new List<OrganizationUnit>();
                organization.Members = new List<OrganizationMember>();

                var userId = Request?.Headers["User"];

                var user = _userLogic.GetUserById(Int32.Parse(userId.Value));

                //Create a Unit and Assign a new member to it
                var unit = new Unit
                {
                    Name = "Default Unit",
                    Members = new List<UnitMember>()
                };

                unit.Members.Add(new UnitMember
                {
                    User = user,
                    Unit = unit
                });

                organization.Units.Add(new OrganizationUnit
                {
                    Unit = unit
                });

                organization.Members.Add(new OrganizationMember
                {
                    User = user,
                    Organization = organization
                });

                organization = await _organizationLogic.CreateOrganization(organization);

                return RedirectToAction(nameof(Organization), new { organization.Id });
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