using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<AddressEntity>>> GetAll([FromServices] IAddressService addressService) {
        try {
            var response = await addressService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AddressEntity>> GetSingle(Guid id, [FromServices] IAddressService addressService) {
        try {
            var response = await addressService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<AddressEntity>> Insert([FromBody] AddressEntity addressEntity, [FromServices] IAddressService addressService) {
        try {
            var response = await addressService.Insert(addressEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<AddressEntity>> Update([FromBody] AddressEntity addressEntity, [FromServices] IAddressService addressService) {
        try {
            var response = await addressService.Update(addressEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IAddressService addressService) {
        try {
            var response = await addressService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
