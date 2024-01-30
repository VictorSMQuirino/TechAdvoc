using TechAdvoc.Domain.Entities;

namespace TechAdvoc.Infrastructure.Repositories;

public class CasoJuridicoRepository : BaseRepository<CasoJuridico>
{
    public CasoJuridicoRepository(TechAdvocDbContext context) : base(context)
    {
    }
}
