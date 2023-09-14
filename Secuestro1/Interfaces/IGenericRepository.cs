namespace Secuestro1;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> ObtenerTodos();
}