using Ibvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ibvc.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) {}

    public DbSet<Usuario> Usuarios { get;set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.HasOne(u => u.Conjuge)
            .WithOne()
            .HasForeignKey<Usuario>(u => u.ConjugeId)
            .OnDelete(DeleteBehavior.Restrict);
        });
    }
}