using ControleDeGasto.Domain.Entities;

namespace ControleDeGasto.Domain.Interfaces.Services
{
    internal interface ICategoryService
    {
        Category AddCategory(Category category);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        void UpdateCategory(Category category);
        void DeleteCategory(int id);

    }
}
