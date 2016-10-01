using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BikeInfo
    {
        public int Id { get; set; }
        public decimal TotalDistance { get; set; }
        public decimal TotalTimeRented { get; set; }

        public virtual Bike Bike { get; set; }
        public int BikeId { get; set; }

        public virtual Location Location { get; set; }
        public int LocationId { get; set; }

    }
}
