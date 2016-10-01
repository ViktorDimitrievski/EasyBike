using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<ApplicationUser>
    {
        ApplicationUser GetById(string id);
        bool Delete(string id);
        ApplicationUser GetByUserName(string name);
    }
}
