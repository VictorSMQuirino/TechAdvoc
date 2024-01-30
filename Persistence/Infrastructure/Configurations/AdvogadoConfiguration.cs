
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvoc.Domain.Entities;

namespace Infrastructure.Configurations;

public class AdvogadoConfiguration: IEntityTypeConfiguration <Advogado>
{
    public void Configure(EntityTypeBuilder<Advogado>Builder)
    {
        Builder 
            .ToTable("Advogados")
            .HasKey(m=>m.Id);
    }
}
