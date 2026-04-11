using NamespaceDemo.Models;
using NamespaceDemo.Services;
using NamespaceDemo.Helpers;

Console.WriteLine("=== Namespace & Project Structure ===\n");

ProductService service = new ProductService();

service.Add(new Product(1, "Keyboard", 79.99m,  "Electronics"));
service.Add(new Product(2, "Mouse",    49.99m,  "Electronics"));
service.Add(new Product(3, "Desk",     249.99m, "Furniture"));
service.Add(new Product(4, "Chair",    189.99m, "Furniture"));
service.Add(new Product(5, "Pen",      1.99m,   "Stationery"));

Console.WriteLine("\n--- All products ---");
foreach (Product p in service.GetAll())
    Console.WriteLine($"  {p}");

Console.WriteLine("\n--- Electronics only ---");
foreach (Product p in service.GetByCategory("Electronics"))
    Console.WriteLine($"  {p}");

Console.WriteLine("\n--- PriceHelper direct usage ---");
decimal discounted = PriceHelper.ApplyDiscount(100m, 20);
Console.WriteLine($"  $100 after 20% discount: {PriceHelper.Format(discounted)}");

Console.WriteLine("\n--- Apply 10% discount to all ---");
service.ApplyDiscountToAll(10);
foreach (Product p in service.GetAll())
    Console.WriteLine($"  {p}");