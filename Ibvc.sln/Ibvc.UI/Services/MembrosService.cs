using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;
using Ibvc.UI.Utils;
using Microsoft.Extensions.Options;

namespace Ibvc.UI.Services;

public class MembrosService : ServiceBase, IMembrosService
{
    private readonly string _url = "membros/nomes";
    
    public MembrosService(HttpClient httpClient, IOptions<ApiSettings> settings) : base(httpClient, settings)
    {
    }

    public async Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync()
    {
        return (await GetAsync<List<NomesMembrosResponse>>(_url));
    }
}