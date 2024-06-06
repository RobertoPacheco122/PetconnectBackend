using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SpecieController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<SpecieEntity>>> GetAll([FromServices] ISpecieService specieService) {
        try {
            var response = await specieService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SpecieEntity>> GetSingle(Guid id, [FromServices] ISpecieService specieService) {
        try {
            var response = await specieService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<SpecieEntity>> Insert([FromBody] SpecieEntity specieEntity, [FromServices] ISpecieService specieService) {
        try {
            var response = await specieService.Insert(specieEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<SpecieEntity>> Update([FromBody] SpecieEntity specieEntity, [FromServices] ISpecieService specieService) {
        try {
            var response = await specieService.Update(specieEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] ISpecieService specieService) {
        try {
            var response = await specieService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
