using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EvaluationController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<EvaluationEntity>>> GetAll([FromServices] IEvaluationService evaluationService) {
        try {
            var response = await evaluationService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("serviceProvider/{id}")]
    public async Task<ActionResult<List<EvaluationEntity>>> GetAllByServiceProvider(Guid id, [FromServices] IEvaluationService evaluationService) {
        try {
            var response = await evaluationService.GetAllByServiceProvider(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EvaluationEntity>> GetSingle(Guid id, [FromServices] IEvaluationService evaluationService) {
        try {
            var response = await evaluationService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<EvaluationEntity>> Insert([FromBody] EvaluationEntity commonUser, [FromServices] IEvaluationService evaluationService) {
        try {
            var response = await evaluationService.Insert(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<EvaluationEntity>> Update([FromBody] EvaluationEntity commonUser, [FromServices] IEvaluationService evaluationService) {
        try {
            var response = await evaluationService.Update(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IEvaluationService evaluationService) {
        try {
            var response = await evaluationService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
