
using AutoMapper;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;

namespace BuberBreakfast.Services;

public class BreakFastService {

    private readonly AppDbContext dbContext;
    private readonly IMapper mapper;
    private readonly ILogger<BreakFastService> logger;

    public BreakFastService(AppDbContext dbContext, IMapper mapper, ILogger<BreakFastService> logger) {
        this.dbContext = dbContext;
        this.mapper = mapper;
        this.logger = logger;
    }
    
    public async Task<BreakFastResponse> createBreakFast(CreateBreakFastRequest createBreakFastRequest) {
        var breakfast = mapper.Map<Breakfast>(createBreakFastRequest);
        dbContext.Add(breakfast);
        await dbContext.SaveChangesAsync();
        logger.LogInformation("Saved breakfast successfully : {}", breakfast.Uuid);
        return mapper.Map<BreakFastResponse>(breakfast);
    }
}