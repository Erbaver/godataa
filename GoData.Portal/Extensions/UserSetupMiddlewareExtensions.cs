using GoData.Core.Logic;
using GoData.Portal.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace GoData.Portal.Extensions
{
    public static class UserSetupMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserSetupMiddleware(this IApplicationBuilder builder, UserLogic userLogic)
        {
            return builder.UseMiddleware<UserSetupMiddleware>(userLogic);
        }
    }
}
