
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Services;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("api/breakfasts")]
public class BreakFastController : ControllerBase {

 private readonly ILogger<BreakFastController> logger;

 private readonly BreakFastService breakFastService;

    public BreakFastController(ILogger<BreakFastController> logger, BreakFastService breakFastService)
    {
        this.logger = logger;
        this.breakFastService = breakFastService;
    }

 [HttpPost]
 public async Task<IActionResult> createBreakFast(CreateBreakFastRequest createBreakFastRequest) {
        
        return Ok(await breakFastService.createBreakFast(createBreakFastRequest));
 }

 [HttpGet]
 public IActionResult getBreakFastById() {
        return Ok(Guid.NewGuid());
 }

}