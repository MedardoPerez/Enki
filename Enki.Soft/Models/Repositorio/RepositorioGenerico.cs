using ENKI.SOFT.Models.Entidades;

namespace ENKI.SOFT.Models.Repositorio
{
    public class RepositorioGenerico<TEntity> : Repository<TEntity>, IRepositoryGenerico<TEntity>
         where TEntity : Entity
    {
        public RepositorioGenerico(UnitOfWorkSmh unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}