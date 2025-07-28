using Ibvc.Api.Endpoints;
using Ibvc.Api.Filters;

namespace Ibvc.Api.Extensions;

public static class AppExtensions
{
    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("v1/")
            .MapAuthEndpoints()
            .AllowAnonymous()
            .AddEndpointFilter<ApiKeyAuthorizationFilter>();
        return app;
    }
}