using core.Dto_Resorses;
using core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Interfaces
{
    public interface IAddressServise
    {
      Task<int> AddAsync(Address address);

        Task<List<AddressWithDistanceDto>> GetClosestWithDistanceAsync(double lat, double lng, int count = 10);
        Task<int> AddReviewAsync(ReviewDto r);
       Task<List<Address>> GetAddressThisMonth();

    }
}
