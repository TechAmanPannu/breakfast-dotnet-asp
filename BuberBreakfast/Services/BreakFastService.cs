
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Entities;

namespace BuberBreakfast.Services;

public class BreakFastService {

    private readonly AppDbContext dbContext;

    public BreakFastService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }
    
    public  async Task<BreakFastResponse> createBreakFast(CreateBreakFastRequest createBreakFastRequest) {
    
        
         var breakfast = new Breakfast
        {
            Name = createBreakFastRequest.Name,
            Description = createBreakFastRequest.Description,
            StartDateTime =  createBreakFastRequest.StartDateTime.ToUniversalTime(),
            EndDateTime = createBreakFastRequest.EndDateTime.ToUniversalTime(),
            Uuid = Guid.NewGuid()
        };


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