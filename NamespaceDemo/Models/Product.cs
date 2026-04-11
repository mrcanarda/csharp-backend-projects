namespace NamespaceDemo.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; }
    public decimal Price { get; set; }
    public string Category { get; }

    public Product(int id, string name, decimal price, string category)
    {
        Id       = id;
        Name     = name;
        Price    = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"[{Id}] {Name} - {Price:C} ({Category})";
    }
}