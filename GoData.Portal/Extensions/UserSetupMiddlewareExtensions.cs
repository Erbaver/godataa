using GoData.Portal.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace GoData.Portal.Extensions
{
    public static class UserSetupMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserSetupMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserSetupMiddleware>();
        }
    }
}
