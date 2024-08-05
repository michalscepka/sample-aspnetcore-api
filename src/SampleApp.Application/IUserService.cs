using SampleApp.Domain;

namespace SampleApp.Application;

public interface IUserService
{
    Task AddUserAsync(User user);
    Task<IEnumerable<User>> GetAllUsersAsync();
}
