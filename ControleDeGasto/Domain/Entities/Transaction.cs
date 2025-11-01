

namespace ControleDeGasto.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Transaction(int id, decimal amount, DateTime date, string description, int categoryId)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Description = description;
            CategoryId = categoryId;
        }

        public Transaction(int id, decimal amount, DateTime date, string description, Category category)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Description = description;
            Category = category;
        }
        public Transaction(decimal amount, DateTime date, string description, int categoryId)
        {
            Amount = amount;
            Date = date;
            Description = description;
            CategoryId = categoryId;
        }
    }
}
