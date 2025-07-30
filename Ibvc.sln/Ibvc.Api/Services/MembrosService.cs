using Ibvc.Domain.DTOs.Requests.Secretaria.Membros;
using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Entities;
using Ibvc.Domain.Interfaces;
using Ibvc.Domain.Interfaces.Repositories;
using Ibvc.Domain.Mappers;

namespace Ibvc.Api.Services;

public class MembrosService(IUsuarioRepository usuarioRepository) : IMembrosService
{
    public async Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync()
    {
        return await usuarioRepository.GetAllNomesMembrosAsync();
    }

    public async Task CadastrarMembroAsync(CadastrarMembroRequest request)
    {
        Usuario usuario = request.ToEntity();
        await usuarioRepository.CadastrarUsuarioAsync(usuario);
    }
}