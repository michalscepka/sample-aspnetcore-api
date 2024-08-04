using Microsoft.Extensions.Logging;
using SampleApp.Application;
using SampleApp.Domain;

namespace SampleApp.Infrastructure;

public class UserService : IUserService
{
    private readonly ILogger<UserService> _logger;

    public UserService(ILogger<UserService> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task AddUserAsync(User user)
    {
        _logger.LogInformation("{firstName}, {lastName}, {yearOfBirth}", user.FirstName, user.LastName, user.YearOfBirth);

        return Task.CompletedTask;
    }
}
