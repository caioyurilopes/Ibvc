using Ibvc.Domain.Entities;
using Ibvc.Domain.Interfaces;
using Ibvc.UI.Utils;
using Microsoft.Extensions.Options;

namespace Ibvc.UI.Services;

public class MembrosService : ServiceBase, IMembrosService
{
    private readonly string _url = "membros/";
    
    public MembrosService(HttpClient httpClient, IOptions<ApiSettings> settings) : base(httpClient, settings)
    {
    }

    public async Task<List<Usuario>?> GetAllUsuariosAsync()
    {
        return await GetAsync<List<Usuario>>(_url);
    }
}