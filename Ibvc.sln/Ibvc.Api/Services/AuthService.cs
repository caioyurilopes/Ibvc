using Ibvc.Domain.DTOs.Requests;
using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Entities;
using Ibvc.Domain.Interfaces;
using Ibvc.Domain.Interfaces.Repositories;

namespace Ibvc.Api.Services;

public class AuthService(IUsuarioRepository usuarioRepository, TokenService tokenService) : IAuthService
{
    public async Task<AuthResponse?> LoginAsync(LoginRequest request)
    {
        Usuario? usuario = await usuarioRepository.GetByCelularAsync(request.Celular);
        if (usuario is null)
            return new AuthResponse
            {
                Succeeded = false,
                Message = "Usuário não encontrado."
            };

        bool senha = BCrypt.Net.BCrypt.Verify(request.Senha, usuario.Senha);
        if (!senha)
            return new AuthResponse
            {
                Succeeded = false,
                Message = "Senha inválida."
            };

        var response = tokenService.GenerateToken(usuario);
        return response;
    }
}