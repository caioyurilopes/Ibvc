using Ibvc.Domain.DTOs.Requests.Secretaria.Membros;
using Ibvc.Domain.DTOs.Responses;

namespace Ibvc.Domain.Interfaces;

public interface IMembrosService
{
    Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync();
    Task CadastrarMembroAsync(CadastrarMembroRequest request);
}