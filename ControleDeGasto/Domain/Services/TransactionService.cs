using ControleDeGasto.Domain.Entities;
using ControleDeGasto.Domain.Interfaces.Repositories;
using ControleDeGasto.Domain.Interfaces.Services;


namespace ControleDeGasto.Domain.Services
{
    internal class TransactionService : ITransactionService
    {
        private readonly TransactionRepository _transactionRepository;

        public TransactionService(TransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public Transaction AddTransaction(Transaction transaction)
        {
            return _transactionRepository.AddTransaction(transaction);
        }

        public void DeleteTransaction(int id)
        {
            _transactionRepository.DeleteTransaction(id);
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAllTransactions();
        }

        public Transaction GetTransactionById(int id)
        {
            return _transactionRepository.GetTransactionById(id);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _transactionRepository.UpdateTransaction(transaction);
        }
    }
}
