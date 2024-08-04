using SampleApp.Domain;

namespace SampleApp.Application.Repositories;

public interface IUserRepository
{
    Task AddUserAsync(User user);
}
