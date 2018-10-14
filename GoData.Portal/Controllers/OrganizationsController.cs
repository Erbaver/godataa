using AutoMapper;
using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoData.Portal.Controllers
{
    [Authorize]
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

                organization = await _logic.CreateOrganization(organization);

                var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;

                string ObjectId = userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier").Value;

                var unit = new Unit
                {
                    OrganizationId = organization.Id,
                    Name = "Default Unit"
                };

                //TODO Save Unit;

                var roles = new List<Role>
                {
                    new Role { RoleName = Entities.Enums.Roles.Admin },
                    new Role { RoleName = Entities.Enums.Roles.DataCollector },
                    new Role { RoleName = Entities.Enums.Roles.Owner },
                    new Role { RoleName = Entities.Enums.Roles.QualityControl},
                    new Role { RoleName = Entities.Enums.Roles.Reader }
                };

                var user = new User
                {
                    OrganizationId = organization.Id,
                    Roles = roles,
                    UnitId = unit.Id,
                    UserId = ObjectId,
                };

                //Save User
                

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