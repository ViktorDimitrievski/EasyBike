using Domain.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Application.Implementation
{
    public class BikeService : IBikeService
    {
        private IBikeRepository bikeRepository;

        public BikeService(IBikeRepository _bikeRepository)
        {
            bikeRepository = _bikeRepository;
        }

        public BikesView GetBikes()
        {
            var bikes = bikeRepository.GetAll();

            throw new NotImplementedException();
        }
    }
}
