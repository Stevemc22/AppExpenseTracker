using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PieroDeTomi.EntityFrameworkCore.Identity.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppExpenseTracker.Areas.Identity.Data
{
    public class CosmosDbContext : CosmosIdentityDbContext<IdentityUser>
    {
        public CosmosDbContext(DbContextOptions dbContextOptions, IOptions<OperationalStoreOptions> options)
   : base(dbContextOptions, options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // DO NOT REMOVE THIS LINE. If you do, your context won't work as expected.
            base.OnModelCreating(builder);

            // TODO: Add your own fluent mappings
        }
    }
}
