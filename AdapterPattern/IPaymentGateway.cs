using System;

namespace AdapterPattern;

public interface IPaymentGateway
{

    void pay(string orderId, double amount);

}
