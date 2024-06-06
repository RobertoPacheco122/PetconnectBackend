using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<MessageEntity>>> GetAll([FromServices] IMessageService messageService) {
        try {
            var response = await messageService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MessageEntity>> GetSingle(Guid id, [FromServices] IMessageService messageService) {
        try {
            var response = await messageService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<MessageEntity>> Insert([FromBody] MessageEntity commonUser, [FromServices] IMessageService messageService) {
        try {
            var response = await messageService.Insert(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<MessageEntity>> Update([FromBody] MessageEntity commonUser, [FromServices] IMessageService messageService) {
        try {
            var response = await messageService.Update(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IMessageService messageService) {
        try {
            var response = await messageService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
