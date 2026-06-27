using System;

namespace AdapterPattern;

class CheckoutService
{
    private IPaymentGateway paymentGateway;

    // Constructor injection for dependency inversion
    public CheckoutService(IPaymentGateway paymentGateway)
    {
        this.paymentGateway = paymentGateway;
    }

    // Business logic to perform checkout
    public void checkout(String orderId, double amount)
    {
        paymentGateway.pay(orderId, amount);
    }
}
