namespace ProductsInventory.api.Models;

public class Product
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }


    public Product()
    {
        ID = "123";
        Name = "unknown";
    }

    public Product(string id, string name, int quantity, double price)
    {
        ID = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}