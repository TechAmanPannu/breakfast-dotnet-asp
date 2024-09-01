
using AutoMapper;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;

namespace BuberBreakfast.Services;

public class BreakFastService {

    private readonly AppDbContext dbContext;
    private readonly IMapper mapper;

    public BreakFastService(AppDbContext dbContext, IMapper mapper) {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }
    
    public  async Task<BreakFastResponse> createBreakFast(CreateBreakFastRequest createBreakFastRequest) {
    
        
        var breakfast = mapper.Map<Breakfast>(createBreakFastRequest);

        dbContext.Add(breakfast);
        await dbContext.SaveChangesAsync();

        return new BreakFastResponse(
            breakfast.Uuid.ToString(),
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime
        );
    }
}