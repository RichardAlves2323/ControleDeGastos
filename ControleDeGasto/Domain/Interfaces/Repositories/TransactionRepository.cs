using ControleDeGasto.Domain.Entities;


namespace ControleDeGasto.Domain.Interfaces.Repositories
{
    public interface TransactionRepository
    {
        Transaction AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int id);
        IEnumerable<Transaction> GetAllTransactions();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
