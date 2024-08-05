namespace SampleApp.Api.Dtos;

public record UserAddRequest(string FirstName, string LastName, ushort YearOfBirth);

public record UserAddResponse(Guid Id, string FirstName, string LastName, ushort YearOfBirth);
