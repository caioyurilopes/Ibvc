using Ibvc.Domain.DTOs.Responses;

namespace Ibvc.Domain.Interfaces;

public interface IMembrosService
{
    Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync();
}