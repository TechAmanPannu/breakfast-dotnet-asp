using AutoMapper;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;

public class BreakFastMapper : Profile
{
    public BreakFastMapper()
    {
        CreateMap<CreateBreakFastRequest, Breakfast>()
        .ForMember(dest => dest.StartDateTime, opt => opt.MapFrom(src => src.StartDateTime.ToUniversalTime()))
        .ForMember(dest => dest.EndDateTime, opt => opt.MapFrom(src => src.EndDateTime.ToUniversalTime()));
    }


}