using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Phoenicia.API.Infrastructure
{
    public class ExtendedClaimsProvider
    {
        public static IEnumerable<Claim> GetClaims(ApplicationUser user)
        {

            List<Claim> claims = new List<Claim>();
                claims.Add(CreateClaim("Claim", "Yes"));
            return claims;
        }

        public static Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value, ClaimValueTypes.String);
        }

    }
}