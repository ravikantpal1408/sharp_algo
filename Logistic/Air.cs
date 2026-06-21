using System;

namespace Logistic;

public class Air : ILogistic
{
    public void Send()
    {
        Console.WriteLine("Sending via air...");
    }
}
