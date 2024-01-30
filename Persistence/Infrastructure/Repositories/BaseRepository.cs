using TechAdvoc.Domain.Common;
using TechAdvoc.Domain.Interfaces;

namespace TechAdvoc.Infrastructure.Repositories;
public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    public TechAdvocDbContext _context { get; set; }

    public BaseRepository(TechAdvocDbContext context)
    {
        _context = context;
    }
    
    public void Create(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> Get(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
