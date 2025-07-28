using Ibvc.Domain.Entities;
using Ibvc.Domain.Interfaces;

namespace Ibvc.Api.Endpoints;

public static class MembrosEndpoints
{
    public static RouteGroupBuilder MapMembrosEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("/", GetAllUsuariosAsync);
        return group;
    }

    private static async Task<List<Usuario>?> GetAllUsuariosAsync(IMembrosService membrosService)
    {
        return await membrosService.GetAllUsuariosAsync();
    }
}