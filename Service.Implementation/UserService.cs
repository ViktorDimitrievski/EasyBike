using Domain.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Implementation
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public ApplicationUser Edit(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetById(string id)
        {
            return userRepository.GetById(id);
        }

        public List<ApplicationUser> GetUsers()
        {
            return userRepository.GetAll();
        }
    }
}
