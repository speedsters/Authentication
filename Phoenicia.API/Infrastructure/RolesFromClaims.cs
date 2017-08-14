using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Phoenicia.API.Infrastructure
{
    public class RolesFromClaims
    {
        public static IEnumerable<Claim> CreateRolesBasedOnClaims(ClaimsIdentity identity)
        {
            List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Role, "anytype"));
            return claims;
        }
    }
}