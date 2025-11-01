using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGasto.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // e.g., "Income" or "Expense"

        public Category(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public Category(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
