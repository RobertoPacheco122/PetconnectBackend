using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceRequestController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<ServiceRequestEntity>>> GetAll([FromServices] IServiceRequestService serviceRequestService) {
        try {
            var response = await serviceRequestService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceRequestEntity>> GetSingle(Guid id, [FromServices] IServiceRequestService serviceRequestService) {
        try {
            var response = await serviceRequestService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ServiceRequestEntity>> Insert([FromBody] ServiceRequestEntity serviceRequest, [FromServices] IServiceRequestService serviceRequestService) {
        try {
            var response = await serviceRequestService.Insert(serviceRequest);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ServiceRequestEntity>> Update([FromBody] ServiceRequestEntity serviceRequest, [FromServices] IServiceRequestService serviceRequestService) {
        try { 
            var response = await serviceRequestService.Update(serviceRequest);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IServiceRequestService serviceRequestService) {
        try {
            var response = await serviceRequestService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
