using EF2.Models;

namespace EF2.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ProductContext _categoryContext;

        public CategoryServices(ProductContext categoryContext)
        {
            _categoryContext = categoryContext;
        }
        public List<Category> GetCategories()
        {
            return _categoryContext.Categories.ToList();
        }

        public Category? GetCategoryById(int id)
        {
            return _categoryContext.Categories.FirstOrDefault(x => x.cId == id);
        }
        public void Add(Category category)
        {
            _categoryContext.Categories.Add(category);
            _categoryContext.SaveChanges();
        }
        public void Edit(Category category)
        {
            var rs = _categoryContext.Categories.FirstOrDefault(x => x.cId == category.cId);
            if(rs != null)
            {
                rs.cId = category.cId;  
                rs.cName = category.cName;
                _categoryContext.Update(rs);
                _categoryContext.SaveChanges();
            }
        }
        public void Remove(int id)
        {
            var rs = _categoryContext.Categories.FirstOrDefault(x => x.cId == id);
            if (rs != null)
            {
                _categoryContext.Categories.Remove(rs);
                _categoryContext.SaveChanges();
            }
        }

    }
}
