using FluentValidation;
using SampleApp.Api.Dtos;

namespace SampleApp.Api.Mappings;

public class ValidationMappingMiddleware
{
    private readonly RequestDelegate _requestDelegate;

    public ValidationMappingMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _requestDelegate(context);
        }
        catch (ValidationException ex)
        {
            context.Response.StatusCode = 400;
            var validationFailureResponse = new ValidationFailureResponse(
                ex.Errors.Select(x => new ValidationResponse(
                    x.PropertyName, x.ErrorMessage)));

            await context.Response.WriteAsJsonAsync(validationFailureResponse);
        }
    }
}
