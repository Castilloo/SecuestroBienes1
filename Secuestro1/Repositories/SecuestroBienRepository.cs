using Secuestro.Models;

namespace Secuestro1.Repositories;

public class SecuestroBienRepository : GenericRepository<SecuestroBiene>, ISecuestroBienRepository
{

    public SecuestroBienRepository(SecuestroDbContext dbContext) : base(dbContext) { }
}