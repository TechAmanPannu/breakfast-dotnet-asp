
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Services;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("api/breakfasts")]
public class BreakFastController : ControllerBase
{

       private readonly BreakFastService _breakFastService;

       public BreakFastController(BreakFastService breakFastService)
       {
              _breakFastService = breakFastService;
       }


       [HttpPost]
       public async Task<IActionResult> CreateBreakFast(CreateBreakFastRequest createBreakFastRequest)
       {
              return Ok(await _breakFastService.CreateBreakFast(createBreakFastRequest));
       }

       [HttpGet("{id}")]
       public IActionResult GetBreakFastById(string id)
       {
              return Ok(_breakFastService.GetById(id));
       }

}