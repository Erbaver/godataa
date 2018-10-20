using GoData.Core.Logic;
using GoData.Core.Repositories;
using GoData.Entities.Entities;
using GoData.Portal.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoData.Portal.Middlewares
{
    public class UserSetupMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly UserLogic _userlogic;

        public UserSetupMiddleware(
            RequestDelegate next,
            UserLogic userLogic)
        {
            _next = next;
            _userlogic = userLogic;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.User != null)
            {

                var userClaims = context.User.Identity as ClaimsIdentity;

                string objectId = userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;

                if (objectId != null)
                {
                    var user = _userlogic.GetUserByUserObjectId(objectId);

                    if (user == null)
                    {
                        //create user
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

                        await _userlogic.AddUser(user);
                    }

                    context.Request.Headers["User"] = user.Id.ToString();
                }
            }

            await _next(context);

        }
    }
}
