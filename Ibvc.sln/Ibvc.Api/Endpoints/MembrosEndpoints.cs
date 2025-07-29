using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;

namespace Ibvc.Api.Endpoints;

public static class MembrosEndpoints
{
    public static RouteGroupBuilder MapMembrosEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("/nomes", GetAllNomesMembrosAsync);
        return group;
    }

    private static async Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync(IMembrosService membrosService)
    {
        return await membrosService.GetAllNomesMembrosAsync();
    }
}