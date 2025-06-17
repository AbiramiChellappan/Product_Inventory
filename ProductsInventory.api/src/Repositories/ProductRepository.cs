using ProductsInventory.api.Models;
using ProductsInventory.Api.Data;

namespace ProductsInventory.api.Repositories;

public class ProductRepository : IProductRepository
{
    // private List<Product> products;
    public ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }
    public Product Get(string id)
    {
        // var product = _context.products.Find(product => product.ID == id);
        Product product = _context.products.Find(id);
        return product;
    }

    public List<Product> GetAll()
    {
        return _context.products.ToList<Product>();
    }

    public void Remove(string id)
    {
        // var product = _context.products.Find(product => product.ID == id);
        Product product = _context.products.Find(id);
        // product.Remove(product);
        _context.products.Remove(product);
        _context.SaveChanges();
    }

    public Product Save(Product product)
    {
        _context.products.Add(product);
        _context.SaveChanges();
        return product;
    }

    public Product Update(string id, Product product)
    {
        _context.products.Update(product);
        _context.SaveChanges();
        return product;
    }
}