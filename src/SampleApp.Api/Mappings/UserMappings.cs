using SampleApp.Api.Dtos;
using SampleApp.Domain;

namespace SampleApp.Api.Mappings;

internal static class UserMappings
{
    public static User ToDomain(this CreateUserRequest request) => new()
    {
        Id = Guid.NewGuid(),
        FirstName = request.FirstName,
        LastName = request.LastName,
        YearOfBirth = request.YearOfBirth
    };

    public static CreateUserResponse ToResponse(this User user) 
        => new(user.Id, user.FirstName, user.LastName, user.YearOfBirth);

    public static User ToDomain(this UpdateUserRequest request) => new()
    {
        Id = request.Id,
        FirstName = request.FirstName,
        LastName = request.LastName,
        YearOfBirth = request.YearOfBirth
    };
}
