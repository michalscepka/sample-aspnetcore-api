namespace SampleApp.Api.Dtos;

public record UserUpdateRequest(Guid id, string FirstName, string LastName, ushort YearOfBirth);
