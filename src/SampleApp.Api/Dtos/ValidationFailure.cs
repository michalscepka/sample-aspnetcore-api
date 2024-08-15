namespace SampleApp.Api.Dtos;

public record ValidationFailureResponse(IEnumerable<ValidationResponse> Errors);

public record ValidationResponse(string PropertyName, string Message);
