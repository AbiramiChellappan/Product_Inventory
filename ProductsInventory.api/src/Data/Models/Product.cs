using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
namespace ProductsInventory.api.Models;

[Table("Products")]
public class Product
{
    [Key]
    public Guid ID { get; set; }
    [MaxLength(50)]
    [Required]
    public required string Name { get; set; }
    public int? Quantity { get; set; }
    
    [Precision(6, 2)]
    public double? Price { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public List<CategoryAttribute>?Categories{ get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTimeOffset CreatedAt { get; } = DateTimeOffset.UtcNow;
    public Product()
    {
        // ID = "123";
        // Name = "unknown";
    }

    public Product(Guid id, string name, int quantity, double price)
    {
        ID = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}