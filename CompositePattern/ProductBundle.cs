namespace CompositePattern;

public class ProductBundle(string bundleName) : ICartItem
{
    private readonly List<ICartItem> _items = new List<ICartItem>();

    public void AddItem(ICartItem item) {
        _items.Add(item);
    }

    public double GetPrice() {
        double total = 0;
        foreach (var item in _items)
        {
            total += item.GetPrice();
        }
        return total;
    }

    
    public void Display(String indent) {
        Console.WriteLine(indent + "Bundle: " + bundleName);
        foreach (var item in _items)
        {
            Display(indent + "  " + item.GetPrice());
        }
    }
}