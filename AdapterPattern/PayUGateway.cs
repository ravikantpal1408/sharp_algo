using System;

namespace AdapterPattern;

public class PayUGateway : IPaymentGateway
{
    public void pay(string orderId, double amount)
    {
        Console.WriteLine($"Paid Rs. {amount} using PayU for the order: {orderId}");
    }
}
