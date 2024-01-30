using TechAdvoc.Domain.Entities;

namespace TechAdvoc.Infrastructure.Repositories;

public class DocumentoRepository : BaseRepository<Documento>
{
    public DocumentoRepository(TechAdvocDbContext context) : base(context)
    {
    }
}
