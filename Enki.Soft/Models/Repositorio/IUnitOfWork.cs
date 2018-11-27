using ENKI.SOFT.Models.Infraestructura.Core;

namespace ENKI.SOFT.Models.Repositorio
{
    public interface IUnitOfWork
    {
        void Commit(TransactionInfo transactionInfo);
    }
}