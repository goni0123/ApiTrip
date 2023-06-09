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
            CreateMap<LoadingOrderIn, LoadingOrderInDto>();
            CreateMap<LoadingOrderOut, LoadingOrderOutDto>();
            CreateMap<Inland_driving,InlandDto>();
            CreateMap<Inland_driving_more,InlandMoreDto>();
            CreateMap<LastRoute,LastRouteDto>();
            CreateMap<Weeks, WeekDto>();
            CreateMap<Inland_week,Inland_WeekDto>();
            CreateMap<Inland_week_more,Inland_Week_MoreDto>();
            CreateMap<IncomingDto,Incoming >();
            CreateMap<RouteInDto,RouteIn > ();
            CreateMap<LoadingCompanyInDto, LoadingCompanyIn>();
            CreateMap<OutgoingDto, Outgoing>();
            CreateMap<RouteOutDto, RouteOut>();
            CreateMap<LoadingCompanyOutDto, LoadingCompanyOut>();
            CreateMap<CostDto, Cost>();
            CreateMap<LoadingOrderInDto, LoadingOrderIn>();
            CreateMap<LoadingOrderOutDto, LoadingOrderOut>();
            CreateMap<InlandDto, Inland_driving>();
            CreateMap<InlandMoreDto, Inland_driving_more>();
            CreateMap<LastRouteDto, LastRoute>();
            CreateMap<WeekDto, Weeks>();
            CreateMap<Inland_WeekDto, Inland_week>();
            CreateMap<Inland_Week_MoreDto, Inland_week_more>();
        }
    }
}
