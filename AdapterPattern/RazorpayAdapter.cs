using System;

namespace AdapterPattern;

class RazorpayAdapter : IPaymentGateway
{
    private RazorpayAPI razorpayAPI;

    public RazorpayAdapter()
    {
        this.razorpayAPI = new RazorpayAPI();
    }

    // Translates the pay() call to RazorpayAPI's makePayment() method
    public void pay(String orderId, double amount)
    {
        razorpayAPI.makePayment(orderId, amount);
    }
}
