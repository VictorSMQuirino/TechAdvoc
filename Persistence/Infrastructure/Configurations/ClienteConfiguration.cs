using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvoc.Domain.Entities;
namespace Infrastructure.Configurations;

public class ClienteConfiguration: IEntityTypeConfiguration <Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente>Builder)
    {
        Builder 
            .ToTable("Clientes")
            .HasKey(m=>m.Id);
    }
}


