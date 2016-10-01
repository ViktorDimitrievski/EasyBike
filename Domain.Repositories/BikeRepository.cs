using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;

namespace Domain.Repositories
{
    public class BikeRepository : IBikeRepository
    {
        private Database db;
        public BikeRepository(Database _db)
        {
            db = _db;
        }
        public Bike Create(Bike item)
        {
            throw new NotImplementedException();
        }

        public Bike Edit(Bike item)
        {
            throw new NotImplementedException();
        }

        public List<Bike> GetAll() =>  db.Bike.Include(c => c.BikeInfo).ToList();
    }
}
