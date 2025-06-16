using ProductsInventory.Controllers;
public class ProductsControllerTests
{
    [Fact]
    public void ProductAdd_ShouldIncreaseCount()
    {
        // Given
        ProductsController productsController = new ProductsController();
        productsController.AddProduct
        var res = productsController.getCount();
        Assert.Equals(1, res);
        // When

        // Then
    }
}