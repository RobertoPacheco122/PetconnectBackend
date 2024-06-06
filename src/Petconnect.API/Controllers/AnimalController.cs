using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<AnimalEntity>>> GetAll([FromServices] IAnimalService animalService) {
        try {
            var response = await animalService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AnimalEntity>> GetSingle(Guid id, [FromServices] IAnimalService animalService) {
        try {
            var response = await animalService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<AnimalEntity>> Insert([FromBody] AnimalEntity animalEntity, [FromServices] IAnimalService animalService) {
        try {
            var response = await animalService.Insert(animalEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<AnimalEntity>> Update([FromBody] AnimalEntity animalEntity, [FromServices] IAnimalService animalService) {
        try {
            var response = await animalService.Update(animalEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IAnimalService animalService) {
        try {
            var response = await animalService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
