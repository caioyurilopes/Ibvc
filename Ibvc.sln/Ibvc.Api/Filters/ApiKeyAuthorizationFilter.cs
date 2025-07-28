using Ibvc.Api.Configurations;
using Microsoft.Extensions.Options;

namespace Ibvc.Api.Filters;

public class ApiKeyAuthorizationFilter : IEndpointFilter
{
    private readonly ApiSecurityOptions _options;

    public ApiKeyAuthorizationFilter(IOptions<ApiSecurityOptions> options)
    {
        _options = options.Value;
    }

    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var httpContext = context.HttpContext;

        if (!httpContext.Request.Headers.TryGetValue(_options.HeaderName, out var extractedApiKey))
        {
            Console.WriteLine($"Header '{_options.HeaderName}' não foi enviado.");
            return Results.Unauthorized();
        }

        if (extractedApiKey != _options.Key)
        {
            Console.WriteLine($"API Key inválida. Recebida: {extractedApiKey}, Esperada: {_options.Key}");
            return Results.Unauthorized();
        }

        return await next(context);
    }
}