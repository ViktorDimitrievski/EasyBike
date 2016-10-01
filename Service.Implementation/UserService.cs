using Domain.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using ViewModels;

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

        public ApplicationUser GetById(string id) => userRepository.GetById(id);

        public UserProfileView GetByUserName(string name)
        {
            var user = userRepository.GetByUserName(name);

            return new UserProfileView
            {
                Name = $"{user.Name} {user.LastName}",
                Address = user.Address,
                BirthDate = user.BirthDate.ToString("dd/MM/yyyy")
            };
        }

        public List<ApplicationUser> GetUsers()
        {
            return userRepository.GetAll();
        }
    }
}
