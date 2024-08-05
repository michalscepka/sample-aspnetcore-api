using Microsoft.Extensions.Logging;
using SampleApp.Application;
using SampleApp.Application.Repositories;
using SampleApp.Domain;

namespace SampleApp.Infrastructure;

public class UserService : IUserService
{
    private readonly ILogger<UserService> _logger;
    private readonly IUserRepository _userRepository;

    public UserService(ILogger<UserService> logger, IUserRepository userRepository)
    {
        _logger = logger;
        _userRepository = userRepository;
    }

    public async Task AddUserAsync(User user)
    {
        _logger.LogInformation("Adding user...");
        await _userRepository.AddUserAsync(user);
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        _logger.LogInformation("Getting all users...");
        return await _userRepository.GetAllAsync();
    }
}
