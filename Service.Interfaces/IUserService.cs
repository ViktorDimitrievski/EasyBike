using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Service.Interfaces
{
    public interface IUserService
    {
        List<ApplicationUser> GetUsers();
        ApplicationUser GetById(string id);
        ApplicationUser Edit(ApplicationUser user);
        UserProfileView GetByUserName(string name);
    }
}
