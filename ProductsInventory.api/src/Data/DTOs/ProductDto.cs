using ProductsInventory.api.Models;
namespace ProductsInventory.api.Data.DTOs;
public class ProductDto //Data Transfor Object
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }

    public List<Category>? Categories { get; set; }
}