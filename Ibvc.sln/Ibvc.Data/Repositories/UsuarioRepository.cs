using Ibvc.Data.Context;
using Ibvc.Domain.Entities;
using Ibvc.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ibvc.Data.Repositories;

public class UsuarioRepository(AppDbContext db) : IUsuarioRepository
{
    private readonly AppDbContext _db = db;

    public async Task<Usuario?> GetByCelularAsync(string celular)
    {
        return await _db.Usuarios
            .FirstOrDefaultAsync(u => u.Celular == celular);
    }

    public async Task<List<Usuario>?> GetAllUsuariosAsync()
    {
        return await _db.Usuarios.ToListAsync();
    }
}