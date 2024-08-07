namespace SampleApp.Api.Dtos;

public record UpdateUserRequest(Guid Id, string FirstName, string LastName, ushort YearOfBirth);
