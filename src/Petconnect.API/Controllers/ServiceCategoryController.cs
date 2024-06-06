using Microsoft.AspNetCore.Mvc;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceCategoryController : ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<ServiceCategoryEntity>>> GetAll([FromServices] IServiceCategoryService serviceCategoryService) {
        try {
            var response = await serviceCategoryService.GetAll();

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceCategoryEntity>> GetSingle(Guid id, [FromServices] IServiceCategoryService serviceCategoryService) {
        try {
            var response = await serviceCategoryService.GetSingle(id);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ServiceCategoryEntity>> Insert([FromBody] ServiceCategoryEntity commonUser, [FromServices] IServiceCategoryService serviceCategoryService) {
        try {
            var response = await serviceCategoryService.Insert(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ServiceCategoryEntity>> Update([FromBody] ServiceCategoryEntity commonUser, [FromServices] IServiceCategoryService serviceCategoryService) {
        try {
            var response = await serviceCategoryService.Update(commonUser);

            return Ok(response);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(Guid id, [FromServices] IServiceCategoryService serviceCategoryService) {
        try {
            var response = await serviceCategoryService.Delete(id);

            return NoContent();
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
