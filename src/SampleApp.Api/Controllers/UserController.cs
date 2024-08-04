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
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
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
        };  // TODO: add factory/extension method

        await _userService.AddUserAsync(user);

        return Ok($"{userDto.FirstName}, {userDto.LastName}, {userDto.YearOfBirth}");
    }
}

public record UserAddDto(string FirstName, string LastName, ushort YearOfBirth);
