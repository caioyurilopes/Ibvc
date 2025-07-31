using Ibvc.Domain.DTOs.Requests.Secretaria.Membros;
using Ibvc.Domain.DTOs.Responses;
using Ibvc.Domain.Interfaces;
using Ibvc.UI.Utils;
using Microsoft.Extensions.Options;

namespace Ibvc.UI.Services;

public class MembrosService : ServiceBase, IMembrosService
{
    private readonly string _url = "membros";

    public MembrosService(HttpClient httpClient, IOptions<ApiSettings> settings) : base(httpClient, settings)
    {
    }

    public async Task<List<NomesMembrosResponse>?> GetAllNomesMembrosAsync()
    {
        string url = _url + "/nomes";
        return (await GetAsync<List<NomesMembrosResponse>>(url));
    }

    public async Task CadastrarMembroAsync(CadastrarMembroRequest request)
    {
        await PostAsync(_url, request);
    }
}