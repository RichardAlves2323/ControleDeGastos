using ControleDeGasto.Domain.Entities;
using ControleDeGasto.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Transaction> GetAllTransactionsWithCategory()
        {
            return _context.Transactions.Include(t => t.Category).ToList();
        }

        public IEnumerable<TransactionGraph> GetTotalTransactionType()
        {
            return _context.Transactions
               .Include(t => t.Category)
               .GroupBy(t => t.Category.Type)
               .Select(g => new TransactionGraph(g.Key, g.Sum(t => t.Amount)))
               .ToList();
        }

        public Transaction GetTransactionById(int id)
        {
            return _context.Transactions.Find(id);
        }

        public Transaction GetTransactionByIdWithCategory(int id)
        {
            return _context.Transactions.Include(t => t.Category).FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<TransactionGraph> GetTransactionGraphs()
        {
            return _context.Transactions
                .Include(t => t.Category)
                .GroupBy(t => t.Category.Name)
                .Select(g => new TransactionGraph(g.Key, g.Sum(t => t.Amount)))
                .ToList();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
        }
    }
}
