using System.Collections.Generic;

namespace ENKI.SOFT.Models.Repositorio
{
    public interface ISql
    {
        IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters);
    }
}