using ProductsInventory.api.Models;

namespace ProductsInventory.api.Repositories;

public class ProductRepository : IProductRepository
{
    private List<Product> products;
    public ProductRepository()
    {
        products = new List<Product>();
    }
    public Product Get(string id)
    {
        var product = products.Find(product => product.ID == id);
        return product;
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public void Remove(string id)
    {
        var product = products.Find(product => product.ID == id);
        products.Remove(product);
    }

    public Product Save(Product product)
    {
        products.Add(product);
        return product;
    }

    public Product Update(Product product)
    {
        throw new NotImplementedException();
    }
}