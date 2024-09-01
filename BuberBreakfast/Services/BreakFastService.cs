
using AutoMapper;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;

namespace BuberBreakfast.Services;

public class BreakFastService
{

    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger<BreakFastService> _logger;

    public BreakFastService(AppDbContext dbContext, IMapper mapper, ILogger<BreakFastService> logger)
    {
        this._dbContext = dbContext;
        this._mapper = mapper;
        this._logger = logger;
    }

    public async Task<BreakFastResponse> createBreakFast(CreateBreakFastRequest createBreakFastRequest)
    {
        var breakfast = _mapper.Map<Breakfast>(createBreakFastRequest);
        _dbContext.Add(breakfast);
        await _dbContext.SaveChangesAsync();
        _logger.LogInformation("Saved breakfast successfully : {}", breakfast.Uuid);
        return _mapper.Map<BreakFastResponse>(breakfast);
    }
}