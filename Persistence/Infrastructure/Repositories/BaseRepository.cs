using Microsoft.EntityFrameworkCore;
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
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public async Task<T> Get(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}
