using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;
using Ibvc.Domain.Interfaces.Repositories;

namespace Ibvc.Api.Services;

public class MembrosService(IUsuarioRepository usuarioRepository) : IMembrosService
{
    public async Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync()
    {
        return await usuarioRepository.GetAllNomesMembrosAsync();
    }
}