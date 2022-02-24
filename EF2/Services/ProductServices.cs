using EF2.Models;

namespace EF2.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ProductContext _productContext;

        public ProductServices(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<Product> GetProducts()
        {
            return _productContext.Products.ToList();
        }
        public Product? GetProductById(int id)
        {
            return _productContext.Products.FirstOrDefault(x => x.pId == id);
        }
        public void Create(Product product)
        {
            _productContext.Add(product);
            _productContext.SaveChanges();
        }

        public void Update(Product product)
        {
            var rs = _productContext.Products.FirstOrDefault(x => x.pId == product.pId);
            if(rs != null)
            {
                rs.pId = product.pId;
                rs.pName = product.pName;
                rs.cId = product.cId;
                rs.Manufacture = product.Manufacture;
                _productContext.Products.Update(rs);
                _productContext.SaveChanges();
            }  
        }
        public void Delete(int id)
        {
            var rs = _productContext.Products.FirstOrDefault(x => x.pId == id);
            if (rs != null)
            {
                _productContext.Products.Remove(rs);
                _productContext.SaveChanges();
            }
        }

    }
}
