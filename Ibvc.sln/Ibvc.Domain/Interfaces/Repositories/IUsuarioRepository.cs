using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Entities;

namespace Ibvc.Domain.Interfaces.Repositories;

public interface IUsuarioRepository
{
    Task<Usuario?> GetByCelularAsync(string celular);
    Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync();
}