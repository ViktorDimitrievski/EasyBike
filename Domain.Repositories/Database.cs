using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class Database : IdentityDbContext<ApplicationUser>
    {
        public Database()
            : base("EasyBikeDb", throwIfV1Schema: false)
        {
        }
        public DbSet<Location> Location { get; set; }
        public DbSet<City> City { get; set; }

        public static Database Create()
        {
            return new Database();
        }

    }
}
