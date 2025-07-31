using Ibvc.Domain.DTOs.Responses;

namespace Ibvc.Domain.Interfaces;

public interface ICepService
{
    Task<CepResponse?> GetEnderecoByCepAsync(string cep);
}