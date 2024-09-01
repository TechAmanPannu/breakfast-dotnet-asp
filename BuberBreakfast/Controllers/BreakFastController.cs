
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Services;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("api/breakfasts")]
public class BreakFastController : ControllerBase {

 private readonly BreakFastService _breakFastService;

    public BreakFastController(BreakFastService breakFastService)
    {
        this._breakFastService = breakFastService;
    }


    [HttpPost]
 public async Task<IActionResult> createBreakFast(CreateBreakFastRequest createBreakFastRequest) {
        return Ok(await _breakFastService.createBreakFast(createBreakFastRequest));
 }

 [HttpGet]
 public IActionResult getBreakFastById() {
        return Ok(Guid.NewGuid());
 }

}