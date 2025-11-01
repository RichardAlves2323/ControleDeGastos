using ControleDeGasto.Domain.Entities;

namespace ControleDeGasto.Domain.Interfaces.Services
{
    public interface ITransactionService
    {
        Transaction AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int id);
        IEnumerable<Transaction> GetAllTransactions();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
