using Ibvc.Domain.DTOs.Requests;
using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;
using Ibvc.UI.Utils;
using Microsoft.Extensions.Options;

namespace Ibvc.UI.Services;

public class AuthService : ServiceBase, IAuthService
{
    private readonly string _url = "auth/";

    public AuthService(HttpClient httpClient, IOptions<ApiSettings> settings) : base(httpClient, settings)
    {
    }

    public async Task<AuthResponse?> LoginAsync(LoginRequest request)
    {
        string url = _url + "login";
        return await PostAsync<AuthResponse>(url, request);
    }
}