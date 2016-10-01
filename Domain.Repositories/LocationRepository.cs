using Domain.Interfaces;
using System;
using System.Collections.Generic;
using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private Database db;
        public LocationRepository(Database _db)
        {
            db = _db;
        }
        public Location Create(Location item)
        {
            throw new NotImplementedException();
        }

        public Location Edit(Location item)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAll()
        {
            return db.Location.ToList();
        }
    }
}
