using Microsoft.EntityFrameworkCore;
using TechAdvoc.Domain.Entities;

namespace TechAdvoc.Infrastructure;
public class TechAdvocDbContext : DbContext
{
    public DbSet<Advogado> Advogados { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<CasoJuridico> CasosJuridicos { get; set; }
    public DbSet<Documento> Documentos { get; set; }

    public TechAdvocDbContext(DbContextOptions<TechAdvocDbContext> options) : base(options)
   {
      //Database.EnsureCreated();
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechAdvocDbContext).Assembly);
   }

}
