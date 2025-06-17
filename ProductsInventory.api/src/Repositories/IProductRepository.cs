using ProductsInventory.api.Models;

namespace ProductsInventory.api.Repositories;

public interface IProductRepository
{
    public Product Save(Product product);
    public List<Product> GetAll();
    public Product Get(string id);
    public Product Update(string id,Product product);
    public void Remove(string id);
}