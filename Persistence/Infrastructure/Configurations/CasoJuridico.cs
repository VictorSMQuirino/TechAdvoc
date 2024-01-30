using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvoc.Domain.Entities;
namespace Infrastructure.Configurations;

public class CasoJuridicoConfiguration: IEntityTypeConfiguration <CasoJuridico>
{
    public void Configure(EntityTypeBuilder<CasoJuridico>Builder)
    {
        Builder 
            .ToTable("CasosJuridicos")
            .HasKey(m=>m.Id);

        Builder 
        .HasOne (m=> m.Cliente)
        .WithOne (m=> m.CasoJuridico)
        .HasForeignKey<Cliente>(m=> m.CasoJuridicoId);
        
        Builder 
        .HasOne (m=> m.Advogado)
        .WithMany (m=> m.CasosJuridicos)
        .HasForeignKey(m=> m.AdvogadoId);
    }
}

