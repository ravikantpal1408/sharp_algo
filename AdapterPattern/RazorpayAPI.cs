using System;

namespace AdapterPattern;

// Adaptee: 
// An existing class with an incompatible interface
class RazorpayAPI
{
    public void makePayment(String invoiceId, double amountInRupees)
    {
        Console.WriteLine("Paid Rs." + amountInRupees + " using Razorpay for invoice: " + invoiceId);
    }
}

