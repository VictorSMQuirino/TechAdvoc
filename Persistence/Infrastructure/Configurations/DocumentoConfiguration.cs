using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvoc.Domain.Entities;
namespace Infrastructure.Configurations;

public class DocumentoConfiguration: IEntityTypeConfiguration <Documento>
{
    public void Configure(EntityTypeBuilder<Documento>Builder)
    {
        Builder 
            .ToTable("Documentos")
            .HasKey(m=>m.Id);

        Builder 
            .HasOne (m=> m.CasoJuridico)
            .WithMany (m=> m.Documentos)
            .HasForeignKey(m=>m.CasoJuridicoId);
    }
}

