using ControleDeGasto.Domain.Entities;


namespace ControleDeGasto.Domain.Interfaces
{
    internal interface CategoryRepository
    {
        Category AddCategory(Category category);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
