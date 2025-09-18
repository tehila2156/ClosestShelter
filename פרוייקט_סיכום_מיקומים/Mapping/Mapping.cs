using AutoMapper;
using core.Models;
using core.Dto_Resorses;

namespace core.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ReviewDto, Review>()
           .ForMember(dest => dest.Images, opt => opt.MapFrom(src =>
            src.Images != null ? string.Join(",", src.Images) : null))
            .ForMember(dest => dest.address, opt => opt.Ignore()) // נקבע בקונטרולר אחרי בדיקה

           .ForMember(dest => dest.Id, opt => opt.Ignore()); // Id יווצר ע"י EF



            // ממודל ל־DTO
            CreateMap<Address, AddressDto>()
                .ForMember(dto => dto.StructureTypeName, opt => opt.MapFrom(src => src.StructureType.Name))
                .ForMember(dto => dto.StructureTypeLevel, opt => opt.MapFrom(src => src.StructureType.Level));

            // מ־DTO למודל
            CreateMap<AddressDto, Address>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.StructureTypeId, opt => opt.Ignore())
                .ForMember(dest => dest.AddedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Reviews, opt => opt.Ignore())
                .ForMember(dest => dest.StructureType, opt => opt.MapFrom(src => new StructureType
                {
                    Name = src.StructureTypeName,
                    Level = src.StructureTypeLevel
                }));
            //// AddressDto → Address
            //CreateMap<AddressDto, Address>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore())
            //    .ForMember(dest => dest.StructureTypeId, opt => opt.Ignore())
            //    .ForMember(dest => dest.StructureType, opt => opt.Ignore())
            //    .ForMember(dest => dest.AddedDate, opt => opt.Ignore())
            //    .ForMember(dest => dest.Reviews, opt => opt.Ignore());
        }
    }
}
