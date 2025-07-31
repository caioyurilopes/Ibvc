using Ibvc.Domain.DTOs.Requests;
using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Ibvc.Api.Endpoints;

public static class AuthEndpoints
{
    public static RouteGroupBuilder MapAuthEndpoints(this RouteGroupBuilder group)
    {
        group.MapPost("/auth/login", LoginAsync);
        return group;
    }

    private static async Task<Results<Ok<AuthResponse>, UnauthorizedHttpResult, ForbidHttpResult>> LoginAsync(
        LoginRequest request,
        IAuthService authService)
    {
        var response = await authService.LoginAsync(request);
        if (!response.Succeeded)
        {
            if (response.Message.Equals("401"))
                return TypedResults.Unauthorized();
            else if (response.Message.Equals("403"))
                return TypedResults.Forbid();
        }

        return TypedResults.Ok(response);
    }
}