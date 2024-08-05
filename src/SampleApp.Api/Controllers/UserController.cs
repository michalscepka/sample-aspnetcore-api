using Microsoft.AspNetCore.Mvc;
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
    [Route("add")]
    public async Task<ActionResult> AddAsync([FromBody] UserAddDto userDto)
    {
        var user = new User
        {
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            YearOfBirth = userDto.YearOfBirth
        };

        await _userService.AddUserAsync(user);

        return Ok($"{userDto.FirstName}, {userDto.LastName}, {userDto.YearOfBirth}");
    }

    [HttpGet]
    [Route("getall")]
    public async Task<ActionResult<IEnumerable<User>>> GetAllAsync()
    {
        var users = await _userService.GetAllUsersAsync();
        return Ok(users);
    }
}

public record UserAddDto(string FirstName, string LastName, ushort YearOfBirth);
