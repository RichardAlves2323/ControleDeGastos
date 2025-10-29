using ControleDeGasto.Domain.Entities;


namespace ControleDeGasto.Domain.Interfaces.Repositories
{
    internal interface CategoryRepository
    {
        Category AddCategory(Category category);
        Category GetCategoryById(int id);

        Category GetCategoryByName(string categoryName);
        IEnumerable<Category> GetAllCategories();
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
