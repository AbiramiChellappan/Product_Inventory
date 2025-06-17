using ProductsInventory.api.Models;
namespace ProductsInventory.api.Services;

using System.Runtime.InteropServices;
using ProductsInventory.api.Repositories;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Product AddProduct(Product product)
    {
        return _productRepository.Save(product);
    }

    public void DeleteProduct(string id)
    {
        Product product = _productRepository.Get(id);
        if (product == null)
        {
            throw new ResourceNotFoundException();
        }
        _productRepository.Remove(id);
    }

    public List<Product> GetAllProducts()
    {
        return _productRepository.GetAll();
    }

     public Product GetProduct(string id)
    {
        return _productRepository.Get(id);
    }

    public Product UpdateProduct(String id,  Product product)
    {
        Product dbproduct = _productRepository.Get(id);
        if (dbproduct == null)
        {
            throw new ResourceNotFoundException();
        }
        if (product.Name != "")
        {
            dbproduct.Name = product.Name;
        }

        Product UpdatedProduct = _productRepository.Save(dbproduct);
        return UpdatedProduct;
    }
}

[Serializable]
internal class ResourceNotFoundException : Exception
{
    public ResourceNotFoundException()
    {
    }

    public ResourceNotFoundException(string? message) : base(message)
    {
    }

    public ResourceNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}