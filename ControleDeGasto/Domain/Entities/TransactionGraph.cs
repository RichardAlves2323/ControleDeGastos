

namespace ControleDeGasto.Domain.Entities
{
    public class TransactionGraph
    {
        public string CategoryName { get; set; }
        public decimal TotalAmount { get; set; }
        public TransactionGraph(string categoryName, decimal totalAmount)
        {
            CategoryName = categoryName;
            TotalAmount = totalAmount;
        }
    }
}
