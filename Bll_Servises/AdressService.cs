using AutoMapper;
using core.Dto_Resorses;
using core.Interfaces;
using core.Models;
using System;

namespace Bll_Servises
{
    public class AdressService : IAddressServise
    {
        private readonly IAddressRepository addressRepository;

        public AdressService(IAddressRepository idr)
        {
            this.addressRepository = idr;
        }

        public async Task<int> AddAsync(Address address)
        {
            if (address != null)
            {
                return await addressRepository.AddAdressAsync(address);
            }
            return 0;
        }

        public async Task<int> AddReviewAsync(ReviewDto r)
        {
           return await addressRepository.AddReviewAsync(r);



        }

        public async Task<List<Address>> GetAddressThisMonth()
        {
            return await addressRepository.GetAddressThisMonth();

        }


        public  async Task<List<AddressWithDistanceDto>> GetClosestWithDistanceAsync(double lat, double lng, int count=10)
        {
            var allAddresses = await addressRepository.GetAllAsync();

            var result = allAddresses
                .Select(a => new AddressWithDistanceDto
                {
                    Location = a.Location,
                    StructureTypeName = a.StructureType.Name,
                    StructureTypeLevel = a.StructureType.Level,
                    IsAlwaysOpen = a.IsAlwaysOpen,
                    ContactPerson = a.ContactPerson,
                    Phone = a.Phone,
                    Sms = a.Sms,
                    Capacity = a.Capacity,
                    CurrentPeople = a.CurrentPeople,
                    Latitude = a.Latitude,
                    Longitude = a.Longitude,
                    DistanceInKm = CalculateDistance(lat, lng, a.Latitude, a.Longitude)
                })
                .OrderBy(x => x.DistanceInKm)
                .Take(count)
                .ToList();

            return result;
        }

       

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371; // רדיוס כדוה"א בק"מ
            double dLat = DegreesToRadians(lat2 - lat1);
            double dLon = DegreesToRadians(lon2 - lon1);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private double DegreesToRadians(double deg) => deg * (Math.PI / 180);






    }
}
