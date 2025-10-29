using ControleDeGasto.Domain.Entities;


namespace ControleDeGasto.Domain.Interfaces
{
    internal interface TransactionRepository
    {
        Transaction AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int id);
        IEnumerable<Transaction> GetAllTransactions();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
