using NamespaceDemo.Models;
using NamespaceDemo.Helpers;

namespace NamespaceDemo.Services;

public class ProductService
{
    private List<Product> _products = new();

    public void Add(Product product)
    {
        _products.Add(product);
        Console.WriteLine($"Added: {product}");
    }

    public List<Product> GetAll() => _products;

    public List<Product> GetByCategory(string category)
    {
        return _products
            .Where(p => p.Category == category)
            .ToList();
    }

    public void ApplyDiscountToAll(double discountPercent)
    {
        foreach (Product p in _products)
        {
            p.Price = PriceHelper.ApplyDiscount(p.Price, discountPercent);
        }
        Console.WriteLine($"Applied {discountPercent}% discount to all products.");
    }
}
