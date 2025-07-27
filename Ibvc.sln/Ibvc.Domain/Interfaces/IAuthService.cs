using Ibvc.Domain.DTOs.Requests;
using Ibvc.Domain.DTOs.Responses;

namespace Ibvc.Domain.Interfaces;

public interface IAuthService
{
    Task<AuthResponse?> LoginAsync(LoginRequest request);
}