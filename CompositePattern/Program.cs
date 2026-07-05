namespace   CompositePattern
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Individual Products
            ICartItem book = new Product("Atomic Habits", 499);
            ICartItem phone = new Product("iPhone 15", 79999);
            ICartItem earbuds = new Product("AirPods", 15999);
            ICartItem charger = new Product("20W Charger", 1999);

            // Combo Deal
            ProductBundle iphoneCombo = new ProductBundle("iPhone Essentials Combo");
            iphoneCombo.AddItem(phone);
            iphoneCombo.AddItem(earbuds);
            iphoneCombo.AddItem(charger);

            // Back to School Kit
            ProductBundle schoolKit = new ProductBundle("Back to School Kit");
            schoolKit.AddItem(new Product("Notebook Pack", 249));
            schoolKit.AddItem(new Product("Pen Set", 99));
            schoolKit.AddItem(new Product("Highlighter", 149));

            // Add everything to cart
            List<ICartItem> cart = new ();
            cart.Add(book);
            cart.Add(iphoneCombo);
            cart.Add(schoolKit);

            // Display cart
            Console.WriteLine("Your Amazon Cart:");
            double total = 0;
            foreach (ICartItem cartItem in cart)
            {
                cartItem.Display(" ");
                total += cartItem.GetPrice();
            }
            Console.WriteLine("\nTotal: ₹" + total);            
            
        }
    }
};

