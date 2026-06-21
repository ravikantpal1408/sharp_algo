using System;

namespace Logistic;

public class LogisticFactory
{

    public static ILogistic GetLogistic(string mode)
    {

        if (mode.Equals("Air", StringComparison.OrdinalIgnoreCase))
        {
            return new Air();
        }
        else if (mode.Equals("Road", StringComparison.OrdinalIgnoreCase))
        {
            return new Road();
        }
        throw new InvalidOperationException("Invalid mode of operation : " + mode);
    }

}
