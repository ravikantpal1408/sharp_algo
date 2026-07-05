namespace CompositePattern;

public class Product(string name, double price) : ICartItem
{
    public double GetPrice()
    {
        return price;
    }

    public void Display(string indent)
    {
        Console.WriteLine(indent + "Product: " + name + " - ₹" + price);
    }
}