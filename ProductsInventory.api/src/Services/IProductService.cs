using ProductsInventory.api.Models;
namespace ProductsInventory.api.Services
{
    public interface IProductService
    {
        public Product GetProduct (string id);
        public Product AddProduct(Product product);
        public List<Product> GetAllProducts();
        public void DeleteProduct(string id);
        public Product UpdateProduct(string id,Product product);
    }
}