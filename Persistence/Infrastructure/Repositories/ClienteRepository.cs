using TechAdvoc.Domain.Entities;

namespace TechAdvoc.Infrastructure.Repositories;

public class ClienteRepository : BaseRepository<Cliente>
{
    public ClienteRepository(TechAdvocDbContext context) : base(context)
    {
    }
}
