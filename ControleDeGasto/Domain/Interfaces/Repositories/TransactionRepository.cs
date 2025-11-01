using ControleDeGasto.Domain.Entities;


namespace ControleDeGasto.Domain.Interfaces.Repositories
{
    public interface TransactionRepository
    {
        Transaction AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int id);
        Transaction GetTransactionByIdWithCategory(int id);
        IEnumerable<Transaction> GetAllTransactions();
        IEnumerable<Transaction> GetAllTransactionsWithCategory();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
        IEnumerable<TransactionGraph> GetTransactionGraphs();

        IEnumerable<TransactionGraph> GetTotalTransactionType();
    }
}
