using Microsoft.AspNetCore.Mvc;
using SampleApp.Api.Dtos;
using SampleApp.Api.Mappings;
using SampleApp.Application;
using SampleApp.Domain;

namespace SampleApp.Api.Controllers;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<ActionResult> Create([FromBody] CreateUserRequest createUserRequest)
    {
        var user = createUserRequest.ToDomain();

        await _userService.CreateAsync(user);

        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user.ToResponse());
    }

    [HttpGet]
    [Route("get/{id:guid}")]
    public async Task<ActionResult> GetById([FromRoute] Guid id)
    {
        var user = await _userService.GetByIdAsync(id);
        
        if (user is null)
            return NotFound($"User {id} not found.");

        return Ok(user);
    }

    [HttpGet]
    [Route("getall")]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        var users = await _userService.GetAllAsync();

        return Ok(users);
    }

    [HttpPut]
    [Route("update")]
    public async Task<ActionResult> Update([FromBody] UpdateUserRequest updateUserRequest)
    {
        var user = updateUserRequest.ToDomain();

        var isUpdated = await _userService.UpdateAsync(user);

        if (!isUpdated)
            return BadRequest();

        return NoContent();
    }

    [HttpDelete]
    [Route("delete/{id:guid}")]
    public async Task<ActionResult> Delete([FromRoute] Guid id)
    {
        var deleted = await _userService.DeleteByIdAsync(id);
        if (!deleted)
            return NotFound();

        return Ok();
    }
}
