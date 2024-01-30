using TechAdvoc.Domain.Entities;

namespace TechAdvoc.Infrastructure.Repositories;

public class AdvogadoRepository : BaseRepository<Advogado>
{
    public AdvogadoRepository(TechAdvocDbContext context) : base(context)
    {
    }
}
