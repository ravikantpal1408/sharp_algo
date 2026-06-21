using System;

namespace Logistic;

public class LogisticService
{
    public void Send(string mode)
    {
        ILogistic logistic = LogisticFactory.GetLogistic(mode);
        logistic.Send();
    }
}
