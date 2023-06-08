using AutoMapper;
using TripRegisterNewAPI.Dto;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Incoming, IncomingDto>();
            CreateMap<RouteIn, RouteInDto>();
            CreateMap<LoadingCompanyIn, LoadingCompanyInDto>();
            CreateMap<Outgoing, OutgoingDto>();
            CreateMap<RouteOut, RouteOutDto>();
            CreateMap<LoadingCompanyOut, LoadingCompanyOutDto>();
            CreateMap<Cost,CostDto>();
        }
    }
}
