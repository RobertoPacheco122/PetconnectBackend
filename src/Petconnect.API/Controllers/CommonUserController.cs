using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CommonUserController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<CommonUserEntity>>> GetAll([FromServices] ICommonUserService commonUserService) {
        try {
            var response = await commonUserService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CommonUserEntity>> GetSingle(Guid id, [FromServices] ICommonUserService commonUserService) {
        try {
            var response = await commonUserService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CommonUserEntity>> Insert([FromBody] CommonUserEntity commonUser, [FromServices] ICommonUserService commonUserService) {
        try {
            var response = await commonUserService.Insert(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<CommonUserEntity>> Update([FromBody] CommonUserEntity commonUser, [FromServices] ICommonUserService commonUserService) {
        try {
            var response = await commonUserService.Update(commonUser);

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
