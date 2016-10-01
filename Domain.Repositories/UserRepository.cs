using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private Database db;
        public UserRepository(Database _db)
        {
            db = _db;
        }
        public ApplicationUser Create(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Edit(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetAll()
        {
            return db.Users.ToList();
        }

        public ApplicationUser GetById(string id)
        {
          return db.Users.FirstOrDefault(c => c.Id == id);
        }
    }
}
