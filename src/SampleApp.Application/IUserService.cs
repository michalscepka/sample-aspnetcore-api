using SampleApp.Domain;

namespace SampleApp.Application;

public interface IUserService
{
    Task CreateAsync(User user);
    Task<User?> GetByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllAsync();
    Task<bool> UpdateAsync(User user);
    Task<bool> DeleteByIdAsync(Guid id);
}
