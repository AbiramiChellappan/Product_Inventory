using Microsoft.AspNetCore.Mvc;
using ProductsInventory.api.Models;
using ProductsInventory.api.Services;
namespace ProductsInventory.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    // public int getCount()
    // {
    //     throw new NotImplementedException("Not yet implemented");
    // }

    private IProductService _productsService;

    public ProductsController(IProductService productService)
    {
        _productsService = productService;
    }

    [HttpPost]
    public ActionResult CreateProduct([FromBody] Product product)
    {
        Product pro = _productsService.AddProduct(product);
        return Ok(product);
    }

    [HttpGet("{id}")]
    public ActionResult GetProduct(string id)
    {
        Product product = _productsService.GetProduct(id);
        return Ok(product);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateProduct([FromBody] Product product, string id)
    {
        Product product1 = _productsService.UpdateProduct(id, product);
        return Ok(product1);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(string id)
    {
        _productsService.DeleteProduct(id);
        return Ok("Product deleted sucessfully");
    }

    [HttpGet]
    public ActionResult GetAllProducts()
    {
        List<Product> product1 = _productsService.GetAllProducts();
        return Ok(product1);
    }
}
