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
        public string Location { get; set; }
        public decimal TotalDistance { get; set; }
        public decimal TotalTimeRented { get; set; }

    }
}
