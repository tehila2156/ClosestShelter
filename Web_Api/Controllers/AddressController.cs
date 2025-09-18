using AutoMapper;
using core.Dto_Resorses;
using core.Interfaces;
using core.Mapping;
using core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressServise Ibll_service;
        private readonly IMapper mapper;

        public AddressController(IAddressServise service, IMapper mapper)
        {
            this. Ibll_service = service;
            this.mapper = mapper;
        }
        
        [HttpPost]
        public async Task<int> Post(AddressDto dto)
        {
            var address = mapper.Map<Address>(dto); // המרה מ־DTO ל־Model
            return await Ibll_service.AddAsync(address); // קריאה ל־BLL
        }

        [HttpGet("last-30-days")]
        public async Task<ActionResult<List<AddressDto>>> GetLast30Days()
        {

            var addresses = await Ibll_service.GetAddressThisMonth();
            var dtos = mapper.Map<List<AddressDto>>(addresses); // ✔️ המרה אוטומטית לרשימה
            return Ok(dtos);
        }

        [HttpPost("add-review")]
        public async Task<ActionResult<int>> AddReview([FromBody] ReviewDto dto)
        {
            
          return await Ibll_service.AddReviewAsync(dto);
          
        }
        [HttpGet("closest")]
        public async Task<ActionResult<List<AddressWithDistanceDto>>> GetClosest([FromQuery] double lat, [FromQuery] double lng)
        {
            var result = await Ibll_service.GetClosestWithDistanceAsync(lat, lng);
            return Ok(result);
        }





    }
}
