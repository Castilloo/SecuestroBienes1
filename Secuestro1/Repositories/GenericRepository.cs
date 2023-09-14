using Microsoft.EntityFrameworkCore;
using Secuestro.Models;

namespace Secuestro1.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly SecuestroDbContext _dbContext;

    public GenericRepository(SecuestroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<TEntity>> ObtenerTodos()
    {
        return await _dbContext.Set<TEntity>().ToListAsync();
    }
}