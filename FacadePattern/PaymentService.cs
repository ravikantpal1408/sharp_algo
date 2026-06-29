namespace FacadePattern;

public class PaymentService
{
    public void MakePayment(string accountId, double amount) {
        Console.WriteLine("Payment of ₹" + amount + " successful for account " + accountId);
    }
}