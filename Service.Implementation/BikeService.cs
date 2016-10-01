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
        private IBikeInfoRepository bikeInfoRepository;
        public BikeService(IBikeRepository _bikeRepository, IBikeInfoRepository _bikeInfoRepository)
        {
            bikeRepository = _bikeRepository;
            bikeInfoRepository = _bikeInfoRepository;
        }

        public BikesView GetBikes()
        {
            var bikes = bikeRepository.GetAll();

            throw new NotImplementedException();
        }

        public BikesView GetBikesLocation()
        {
            var bikes = bikeInfoRepository.GetAll();

            return new BikesView();
        }
    }
}
