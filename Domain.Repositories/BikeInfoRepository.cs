using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace Domain.Repositories
{
    public class BikeInfoRepository : IBikeInfoRepository
    {
        private Database db;
        public BikeInfoRepository(Database _db)
        {
            db = _db;
        }
        public BikeInfo Create(BikeInfo item)
        {
            throw new NotImplementedException();
        }

        public BikeInfo Edit(BikeInfo item)
        {
            throw new NotImplementedException();
        }

        public List<BikeInfo> GetAll()
        {
          return db.BikeInfo.Include(c => c.Location).ToList();
        }
    }
}
