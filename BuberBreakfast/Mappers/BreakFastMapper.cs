using AutoMapper;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;

public class BreakFastMapper : Profile
{
    public BreakFastMapper()
    {
        CreateMap<CreateBreakFastRequest, Breakfast>()
        .ForMember(dest => dest.StartDateTime, opt => opt.MapFrom(src => src.StartDateTime.ToUniversalTime()))
        .ForMember(dest => dest.EndDateTime, opt => opt.MapFrom(src => src.EndDateTime.ToUniversalTime()))
        .AfterMap((src, dest) =>
            {
                // Set a new Guid for Id if it hasn't been set
                if (dest.Uuid == Guid.Empty)
                {
                    dest.Uuid = Guid.NewGuid();
                }
            });

        CreateMap<Breakfast, BreakFastResponse>()
        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Uuid));
    }


}