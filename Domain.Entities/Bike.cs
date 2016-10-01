using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bike
    {
        public int Id { get; set; }
        public int UniqueCode { get; set; }
        public string Model { get; set; }

        public virtual BikeInfo BikeInfo { get; set; }
        public int BikeInfoId { get; set; }


    }
}
