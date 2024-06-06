using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ChatController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<ChatEntity>>> GetAll([FromServices] IChatService chatService) {
        try {
            var response = await chatService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ChatEntity>> GetSingle(Guid id, [FromServices] IChatService chatService) {
        try {
            var response = await chatService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ChatEntity>> Insert([FromBody] ChatEntity chatEntity, [FromServices] IChatService chatService) {
        try {
            var response = await chatService.Insert(chatEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ChatEntity>> Update([FromBody] ChatEntity chatEntity, [FromServices] IChatService chatService) {
        try {
            var response = await chatService.Update(chatEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IChatService chatService) {
        try {
            var response = await chatService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
