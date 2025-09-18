using AutoMapper;
using core.Dto_Resorses;
using core.Interfaces;
using core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository_Infrastracture.Data_Repository
{
    public class AddressDal : IAddressRepository
    {
        private readonly Context db;

        public AddressDal(Context c)
        {
            this.db = c;

        }
        public async Task<List<Address>> GetAllAsync()
        {
            return await db.Adress
                .Include(a => a.StructureType)
                .ToListAsync();
        }

        public async Task<int> AddAdressAsync(Address address)
        {
            if (string.IsNullOrEmpty(address.Location))
                throw new ArgumentException("כתובת אינה יכולה להיות ריקה");

            var nameToMatch = address.StructureType?.Name?.Trim().ToLower();


            var structureType = await db.StructureTypes.FirstOrDefaultAsync(t =>
                t.Name.Trim().ToLower() == nameToMatch);

            if (structureType == null)
            {
                structureType = new StructureType
                {
                    Name = nameToMatch,
                    BuildYear = 0,
                    Level = ""
                };
                await db.StructureTypes.AddAsync(structureType);
                await db.SaveChangesAsync();
            }
            address.StructureType = null;
            address.StructureTypeId = structureType.Id;
            address.AddedDate = DateTime.UtcNow;

            await db.Adress.AddAsync(address);
            return await db.SaveChangesAsync();
        }

        public async Task<int> AddReviewAsync(ReviewDto r)
        {

            if (string.IsNullOrWhiteSpace(r.location))
                return 0;

            // חיפוש הכתובת לפי שם
            var address = await db.Adress
                .FirstOrDefaultAsync(a => a.Location.Trim() == r.location.Trim());
          
            if (address == null)
                return 0;

            // המרה מ־DTO ל־Model
            var review = Mapper.Map<Review>(r);
            review.address = address;
            address.Reviews.Add(review);
            await db.Reviews.AddAsync(review);
            return await db.SaveChangesAsync();
        }

        public async Task<List<Address>> GetAddressThisMonth()
        {
            var dateLimit = DateTime.Now.AddDays(-30);

            return await db.Adress
        .Include(a => a.StructureType)
        .Include(a => a.Reviews)
        .Where(a => a.AddedDate >= dateLimit)
        .ToListAsync();
        }
    }
}
