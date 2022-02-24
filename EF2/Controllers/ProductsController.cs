using EF2.Models;
using EF2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;

        public ProductsController(IProductServices productServices, ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
        }
        //Categories
        [HttpGet("Category")]
        public List<Category> GetCategories()
        {
            return _categoryServices.GetCategories();
        }
        [HttpGet("cId")]
        public Category? GetCategoryById(int id)
        {
            return _categoryServices.GetCategoryById(id);   
        }
        [HttpPost("Category")]
        public void Add(Category category)
        {
            _categoryServices.Add(category);
        }
        [HttpPut("category")]
        public void Update(Category category)
        {
            _categoryServices.Edit(category);
        }
        [HttpDelete("cId")]
        public void Del(int id)
        {
            _categoryServices.Remove(id);   
        }





        //Products
        [HttpGet("all-product")]
        public List<Product> GetProducts()
        {
            return _productServices.GetProducts();
        }
        [HttpGet("product-pId")]
        public Product? GetById(int id)
        {
            return _productServices.GetProductById(id);
        } 
        [HttpPost("product")]
        public void Add(Product product)
        {
            _productServices.Create(product);
        }
        [HttpPut("product")]
        public void Edit(Product product)
        {
            _productServices.Update(product);
        }
        [HttpDelete("product-byId")]
        public void Delete(int id)
        {
            _productServices.Delete(id);    
        }
        
    }
}
