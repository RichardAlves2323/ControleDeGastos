using ControleDeGasto.Domain.Entities;

namespace ControleDeGasto.Domain.Interfaces.Services
{
    public interface ITransactionService
    {
        Transaction AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int id);

        Transaction GetTransactionByIdWithCategory(int id);
        IEnumerable<Transaction> GetAllTransactions();
        IEnumerable<Transaction> GetAllTransactionsWithCategory();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
