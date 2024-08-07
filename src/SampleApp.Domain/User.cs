namespace SampleApp.Domain;

public class User
{
    public required Guid Id { get; init; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required ushort YearOfBirth { get; set; }
}
