using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using Phoenicia.API.Helpers;

namespace Phoenicia.API.Services
{
    public class PassCode
    {
        public static string GeneratePresharedKey()
        {
            byte[] key = new byte[4]; // 32 bits
            using (var rngProvider = new RNGCryptoServiceProvider())
            {
                rngProvider.GetBytes(key);
            }

            return key.ToBase32String();
        }
    }
    }
