using SampleApp.Application.Repositories;
using SampleApp.Domain;

namespace SampleApp.Infrastructure.EFCore.Repositories;

internal class UserRepository : IUserRepository
{
    public Task AddUserAsync(User user)
    {
        throw new NotImplementedException();
    }
}
