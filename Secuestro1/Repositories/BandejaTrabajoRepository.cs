using Secuestro.Models;

namespace Secuestro1.Repositories;

public class BandejaTrabajoRepository : GenericRepository<BandejaTrabajo>, IBandejaTrabajoRepository
{
    public BandejaTrabajoRepository(SecuestroDbContext dbContext) : base(dbContext) { }
}