using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalDistance { get; set; }

        public ICollection<Location> Locations { get; set; }


    }
}
