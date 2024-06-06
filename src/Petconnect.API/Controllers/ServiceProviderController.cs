using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceProviderController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<ServiceProviderEntity>>> GetAll([FromServices] IServiceProviderService serviceProviderService) {
        try {
            var response = await serviceProviderService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceProviderEntity>> GetSingle(Guid id, [FromServices] IServiceProviderService serviceProviderService) {
        try {
            var response = await serviceProviderService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ServiceProviderEntity>> Insert([FromBody] ServiceProviderEntity serviceProvider, [FromServices] IServiceProviderService serviceProviderService) {
        try {
            var response = await serviceProviderService.Insert(serviceProvider);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ServiceProviderEntity>> Update([FromBody] ServiceProviderEntity serviceProvider, [FromServices] IServiceProviderService serviceProviderService) {
        try {
            var response = await serviceProviderService.Update(serviceProvider);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IServiceProviderService serviceProviderService) {
        try {
            var response = await serviceProviderService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
