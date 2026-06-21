using System;

namespace Logistic;

public class Road : ILogistic
{
    public void Send()
    {
        Console.WriteLine("Sending via road...");
    }
}
