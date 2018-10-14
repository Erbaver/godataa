using AutoMapper;
using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

                var unit = new Unit
                {
                    Name = "Default Unit",
                    Members = new List<UnitMember>()
                };

                organization.Units.Add(new OrganizationUnit
                {
                    Unit = unit
                });

                var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;

                string objectId = userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier").Value;

                var user = _userLogic.GetUserByUserObjectId(objectId);

                if (user != null)
                {
                    var x = user.Organizations;

                    organization.Members.Add(new OrganizationMember
                    {
                        User = user,
                        Organization = organization
                    });

                    unit.Members.Add(new UnitMember
                    {
                        User = user,
                        Unit = unit
                    });
                }
                else
                {
                    user = new User
                    {
                        UserObjectId = objectId,

                        Roles = new List<Role>
                        {
                            new Role { RoleName = Entities.Enums.Roles.Admin },
                            new Role { RoleName = Entities.Enums.Roles.DataCollector },
                            new Role { RoleName = Entities.Enums.Roles.Owner },
                            new Role { RoleName = Entities.Enums.Roles.QualityControl},
                            new Role { RoleName = Entities.Enums.Roles.Reader }
                        }
                    };

                    organization.Members.Add(new OrganizationMember
                    {
                        User = user,
                        Organization = organization
                    });

                    unit.Members.Add(new UnitMember
                    {
                        User = user,
                        Unit = unit
                    });
                }

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