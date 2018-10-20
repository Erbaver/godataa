using GoData.Core.Logic;
using GoData.Core.Repositories;
using GoData.Portal.Helpers;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoData.Portal.Middlewares
{
    public class UserSetupMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly UserLogic _userLogic;

        public UserSetupMiddleware(
            RequestDelegate next,
            UserLogic userLogic)
        {
            _next = next;
            _userLogic = userLogic;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.User != null)
            {

                var userClaims = context.User.Identity as ClaimsIdentity;

                string objectId = userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;

                if (objectId != null)
                {
                    //check if user is created
                    _userLogic.GetUserByUserObjectId(objectId);
                }
            }

            await _next(context);

        }
    }
}
