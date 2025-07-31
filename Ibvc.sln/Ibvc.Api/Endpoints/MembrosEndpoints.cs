using Ibvc.Domain.DTOs.Requests.Secretaria.Membros;
using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;

namespace Ibvc.Api.Endpoints;

public static class MembrosEndpoints
{
    public static RouteGroupBuilder MapMembrosEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("/nomes", GetAllNomesMembrosAsync);
        group.MapPost("/", CadastrarMembroAsync);
        return group;
    }

    private static async Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync(IMembrosService membrosService)
    {
        return await membrosService.GetAllNomesMembrosAsync();
    }

    private static async Task<IResult> CadastrarMembroAsync(CadastrarMembroRequest request,
        IMembrosService membrosService)
    {
        await membrosService.CadastrarMembroAsync(request);
        return Results.Created($"/v1/membros", null);
    }
}