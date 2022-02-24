using EF2.Models;

namespace EF2.Services
{
    public interface ICategoryServices
    {
        void Add(Category category);
        List<Category> GetCategories();
        Category? GetCategoryById(int id);
        void Edit(Category category);
        void Remove(int id);
    }
}
