using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public class CityRepository : ICityRepository
    {
        public Database db;
        public CityRepository(Database _db)
        {

        }
        public City Create(City item)
        {
            throw new NotImplementedException();
        }

        public City Edit(City item)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            return db.City.ToList();
        }
    }
}
