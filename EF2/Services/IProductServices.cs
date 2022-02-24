using EF2.Models;

namespace EF2.Services
{
    public interface IProductServices
    {
        void Create(Product product);
        List<Product> GetProducts();
        Product? GetProductById(int id);
        void Update(Product product);
        void Delete(int id);
    }
}
