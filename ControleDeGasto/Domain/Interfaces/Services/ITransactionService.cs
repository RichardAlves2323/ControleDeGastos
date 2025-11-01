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
        IEnumerable<TransactionGraph> GetTransactionGraphs();
        IEnumerable<TransactionGraph> GetTotalTransactionType();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
