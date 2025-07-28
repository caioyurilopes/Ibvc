using Ibvc.Domain.Entities;
using Ibvc.Domain.Interfaces;
using Ibvc.Domain.Interfaces.Repositories;

namespace Ibvc.Api.Services;

public class MembrosService(IUsuarioRepository usuarioRepository) : IMembrosService
{
    public async Task<List<Usuario>?> GetAllUsuariosAsync()
    {
        return await usuarioRepository.GetAllUsuariosAsync();
    }
}