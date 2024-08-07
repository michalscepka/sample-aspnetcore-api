namespace SampleApp.Api.Dtos;

public record CreateUserRequest(string FirstName, string LastName, ushort YearOfBirth);

public record CreateUserResponse(Guid Id, string FirstName, string LastName, ushort YearOfBirth);
