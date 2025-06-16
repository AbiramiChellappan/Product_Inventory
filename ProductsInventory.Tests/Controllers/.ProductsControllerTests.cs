using Microsoft.AspNetCore.Mvc;
using ProductsInventory.api.Models;
using ProductsInventory.api.Controllers;
public class ProductsControllerTests
{
    [Fact]
    public void ProductAdd_ShouldReturnOk()
    {
        // Given
        ProductsController productsController = new ProductsController();
        // productsController.AddProduct
        var res = productsController.CreateProduct(new Product("123","Abi",05,8765.43));
        Assert.IsType<OkObjectResult>(res);
        // When

        // Then
    }
    [Fact]
    public void ProductGet_ShouldReturnOk()
    {
        // Given
        ProductsController productsController = new ProductsController();
        var res = productsController.GetProduct();
        Assert.IsType<OkResult>(res);
        // When

        // Then
    }
}