using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleApp.Application.Repositories;
using SampleApp.Domain;

namespace SampleApp.Infrastructure.EFCore.Repositories;

internal class UserRepository : IUserRepository
{
    private readonly ILogger<UserRepository> _logger;
    private readonly SampleAppDbContext _context;

    public UserRepository(ILogger<UserRepository> logger, SampleAppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task AddUserAsync(User user)
    {
        var userModel = new Models.User
        {
            Id = Guid.NewGuid(),
            FirstName = user.FirstName,
            LastName = user.LastName,
            YearOfBirth = user.YearOfBirth
        };

        _ = await _context.Users.AddAsync(userModel);
        var entriesCount = await _context.SaveChangesAsync();
        _logger.LogInformation("Saved entries count: {entriesCount}", entriesCount.ToString());
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return (await _context.Users.ToListAsync()).Select(u => new User { FirstName = u.FirstName, LastName = u.LastName, YearOfBirth = u.YearOfBirth });
    }
}
