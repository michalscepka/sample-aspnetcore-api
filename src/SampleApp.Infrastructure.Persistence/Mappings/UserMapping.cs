using SampleApp.Domain;

namespace SampleApp.Infrastructure.Persistence.Mappings;

internal static class UserMapping
{
    public static User ToDomain(this Models.User userModel) => new()
    {
        Id = userModel.Id,
        FirstName = userModel.FirstName,
        LastName = userModel.LastName,
        YearOfBirth = userModel.YearOfBirth
    };

    public static Models.User ToModel(this User user) => new()
    {
        Id = user.Id,
        FirstName = user.FirstName,
        LastName = user.LastName,
        YearOfBirth = user.YearOfBirth
    };
}
