using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<ServiceEntity>>> GetAll([FromServices] IServiceService serviceService) {
        try {
            var response = await serviceService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceEntity>> GetSingle(Guid id, [FromServices] IServiceService serviceService) {
        try {
            var response = await serviceService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ServiceEntity>> Insert([FromBody] ServiceEntity commonUser, [FromServices] IServiceService serviceService) {
        try {
            var response = await serviceService.Insert(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ServiceEntity>> Update([FromBody] ServiceEntity commonUser, [FromServices] IServiceService serviceService) {
        try {
            var response = await serviceService.Update(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IServiceService serviceService) {
        try {
            var response = await serviceService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
