using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<UserEntity>>> GetAll([FromServices] IUserService userService) {
        try {
            var response = await userService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserEntity>> GetSingle(Guid id, [FromServices] IUserService userService) {
        try {
            var response = await userService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<UserEntity>> Insert([FromBody] UserEntity userEntity, [FromServices] IUserService userService) {
        try {
            var response = await userService.Insert(userEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<UserEntity>> Update([FromBody] UserEntity userEntity, [FromServices] IUserService userService) {
        try {
            var response = await userService.Update(userEntity);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IUserService userService) {
        try {
            var response = await userService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
