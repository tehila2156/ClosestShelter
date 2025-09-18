using core.Dto_Resorses;
using core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Interfaces
{

    public interface IAddressRepository
    {

        Task<int> AddAdressAsync(Address address);
        Task<int> AddReviewAsync(ReviewDto r);
        public Task<List<Address>> GetAllAsync();
        Task<List<Address>> GetAddressThisMonth();

    }
}
