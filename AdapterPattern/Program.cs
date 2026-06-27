namespace AdapterPattern;

public class Program
{
    public static void Main(string[] args)
    {
        // Using razorpay payment gateway adapter to process payment
        CheckoutService checkoutService = new CheckoutService(new RazorpayAdapter());

        checkoutService.checkout("12", 1780);
    }
}
