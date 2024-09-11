using AutoMapper;
using Core;

using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {
            CreateMap<Stock, StockDto>().ReverseMap();

        }
    }
}
