namespace Logistic;

public class Program
{
    public static void Main(string[] args)
    {
        LogisticService logisticService = new LogisticService();
        logisticService.Send("Air");
        logisticService.Send("Road");
    }
}