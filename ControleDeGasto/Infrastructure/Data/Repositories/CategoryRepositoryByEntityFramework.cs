using ControleDeGasto.Domain.Entities;
using ControleDeGasto.Domain.Interfaces.Repositories;

namespace ControleDeGasto.Infrastructure.Data.Repositories
{
    internal class CategoryRepositoryByEntityFramework : CategoryRepository
    {
        private readonly GastoContext _context = new GastoContext();
        public Category AddCategory(Category category)
        {
            var categorySaved = _context.Categories.Add(category);
            _context.SaveChanges();

            return categorySaved.Entity;
        }

        public void DeleteCategory(int id)
        {
            _context.Categories.Remove(GetCategoryById(id));
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        { 
            return _context.Categories.Find(id);
        }

        public Category GetCategoryByName(string categoryName)
        {
            return _context.Categories.FirstOrDefault(c => c.Name == categoryName);
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
