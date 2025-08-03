using AutoMapper;
using SmartShippingAPI.DTOs;
using SmartShippingAPI.Models;

namespace SmartShippingAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShippingRequestDto, ShippingRequest>();
        }
    }
}
