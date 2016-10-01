using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Database : IdentityDbContext<ApplicationUser>
    {
        public Database()
            : base("EasyBikeDb", throwIfV1Schema: false)
        {
        }

        public static Database Create()
        {
            return new Database();
        }
    }
}
