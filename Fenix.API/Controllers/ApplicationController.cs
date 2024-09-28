using Microsoft.AspNetCore.Mvc;

namespace Fenix.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ApplicationController : ControllerBase
{
    [HttpGet("mur/ars")]
    public async Task<IActionResult> Get()
    {
        return Ok("че там");
    }
    
    
}