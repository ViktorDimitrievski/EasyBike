using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public class IUserService
    {
        private IUserRepository userRepository;

        public IUserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

    }
}
