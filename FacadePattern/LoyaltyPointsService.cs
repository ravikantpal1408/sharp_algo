namespace FacadePattern;

public class LoyaltyPointsService
{
    public void AddPoints(string accountId, int points) {
        Console.WriteLine(points + " loyalty points added to account " + accountId);
    }
}