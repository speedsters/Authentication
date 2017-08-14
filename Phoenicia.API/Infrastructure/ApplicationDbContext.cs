using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Phoenicia.API.Migrations;
using Phoenicia.API.Models;

namespace Phoenicia.API.Infrastructure
{
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext()
                : base("ApplicationDbContext", throwIfV1Schema: false)
            {
                Configuration.ProxyCreationEnabled = false;
                Configuration.LazyLoadingEnabled = false;
            }
            public DbSet<Client> Clients { get; set; }
            public DbSet<RefreshToken> RefreshTokens { get; set; }
            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }

        }
    }