using SampleApp.Api.Dtos;
using SampleApp.Domain;

namespace SampleApp.Api.Mappings;

internal static class UserMappings
{
    public static User ToDomain(this UserAddRequest request) => new User
    {
        Id = Guid.NewGuid(),
        FirstName = request.FirstName,
        LastName = request.LastName,
        YearOfBirth = request.YearOfBirth
    };

    public static UserAddResponse ToAddResponse(this User user) 
        => new(user.Id, user.FirstName, user.LastName, user.YearOfBirth);

    public static User ToDomain(this UserUpdateRequest request) => new User
    {
        Id = request.id,
        FirstName = request.FirstName,
        LastName = request.LastName,
        YearOfBirth = request.YearOfBirth
    };
}
