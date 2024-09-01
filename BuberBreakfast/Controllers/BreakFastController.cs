
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("api/breakfasts")]
public class BreakFastController : ControllerBase {

 private readonly ILogger<BreakFastController> logger;
    public BreakFastController(ILogger<BreakFastController> logger)
    {
        this.logger = logger;
    }

 [HttpPost]
 public IActionResult createBreakFast(CreateBreakFastRequest createBreakFastRequest) {
        
        return Ok(createBreakFastRequest);
 }

 [HttpGet]
 public IActionResult getBreakFastById() {
        return Ok(new Guid());
 }

}