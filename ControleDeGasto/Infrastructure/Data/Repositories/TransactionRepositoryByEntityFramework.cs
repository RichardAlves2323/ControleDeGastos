using ControleDeGasto.Domain.Entities;
using ControleDeGasto.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGasto.Infrastructure.Data.Repositories
{
    internal class TransactionRepositoryByEntityFramework : TransactionRepository
    {

        private readonly GastoContext _context = new GastoContext();
        public Transaction AddTransaction(Transaction transaction)
        {
            var transactionSaved = _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transactionSaved.Entity;
        }

        public void DeleteTransaction(int id)
        {
            _context.Transactions.Remove(GetTransactionById(id));
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetTransactionById(int id)
        {
            return _context.Transactions.Find(id);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
        }
    }
}
