namespace SampleApp.Infrastructure.EFCore.Models;

public class User
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public ushort YearOfBirth { get; init; }
}
