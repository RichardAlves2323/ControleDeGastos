using ControleDeGasto.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ControleDeGasto.Infrastructure.Data
{
    internal class GastoContext : DbContext
    {
       

        public DbSet<Category> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gastos.db");
        }
    }
    
}
