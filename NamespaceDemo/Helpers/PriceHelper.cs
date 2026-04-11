namespace NamespaceDemo.Helpers;

public static class PriceHelper
{
    public static decimal ApplyDiscount(decimal price, double discountPercent)
    {
        return price * (1 - (decimal)discountPercent / 100);
    }

    public static string Format(decimal price)
    {
        return price.ToString("C");
    }
}
