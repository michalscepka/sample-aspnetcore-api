namespace SampleApp.Api.Dtos;

public record UpdateUserRequest(Guid id, string FirstName, string LastName, ushort YearOfBirth);
