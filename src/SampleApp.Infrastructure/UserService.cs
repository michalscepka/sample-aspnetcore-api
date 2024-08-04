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
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    public async Task AddUserAsync(User user)
    {
        _logger.LogInformation("Adding user...");
        await _userRepository.AddUserAsync(user);

    }
}
