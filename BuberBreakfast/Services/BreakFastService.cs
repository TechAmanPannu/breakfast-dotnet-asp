
using AutoMapper;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;
using BuberBreakfast.Excetions;

namespace BuberBreakfast.Services;

public class BreakFastService
{

    private readonly IServiceProvider _serviceProvider;
    private readonly IMapper _mapper;
    private readonly ILogger<BreakFastService> _logger;

    public BreakFastService(IServiceProvider serviceProvider, IMapper mapper, ILogger<BreakFastService> logger)
    {
        this._serviceProvider = serviceProvider;
        this._mapper = mapper;
        this._logger = logger;
    }

    public async Task<BreakFastResponse> CreateBreakFast(CreateBreakFastRequest createBreakFastRequest)
    {
        var breakfast = _mapper.Map<Breakfast>(createBreakFastRequest);

        using (var scope = _serviceProvider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            dbContext.Add(breakfast);
            await dbContext.SaveChangesAsync();
            _logger.LogInformation("Breakfast saved successfully : {}", breakfast.Uuid);
        }

        return _mapper.Map<BreakFastResponse>(breakfast);
    }

    public BreakFastResponse GetById(string id)
    {

        throw new EntityNotFoundException("Not Found");
    }
}