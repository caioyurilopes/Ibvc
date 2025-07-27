using Ibvc.Domain.Entities;

namespace Ibvc.Domain.Interfaces.Repositories;

public interface IUsuarioRepository
{
    Task<Usuario?> GetByCelularAsync(string celular);
}