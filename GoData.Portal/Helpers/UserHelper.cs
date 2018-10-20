using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoData.Portal.Helpers
{
    public class UserHelper
    {
        private Dictionary<string, string> _userProperties;

        public Dictionary<string, string> GetUserProperties(ClaimsPrincipal user)
        {
            if (this._userProperties != null)
                return this._userProperties;

            var dictionary = new Dictionary<string, string>();

            var userClaims = user.Identity as ClaimsIdentity;

            string objectId = userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier").Value;

            dictionary.Add("ObjectId", objectId);

            this._userProperties = dictionary;

            return this._userProperties;
        }
    }
}
