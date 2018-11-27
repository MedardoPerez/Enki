using ENKI.SOFT.Models.Entidades;

namespace ENKI.SOFT.Models.Repositorio
{
    public interface IRepositoryGenerico<TEntity> : IRepository<TEntity>
       where TEntity : Entity
    {
    }
}