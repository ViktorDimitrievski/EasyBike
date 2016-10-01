using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserRepository : IBaseRepository<ApplicationUser> : IUserRepository
    {
        public ApplicationUser Create(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Edit(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
