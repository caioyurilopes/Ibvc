using Ibvc.Domain.Entities;

namespace Ibvc.Domain.Interfaces;

public interface IMembrosService
{
    Task<List<Usuario>?> GetAllUsuariosAsync();
}