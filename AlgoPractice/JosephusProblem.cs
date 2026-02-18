using System;

namespace AlgoPractice;

public class JosephusProblem
{
    public static void FindTheLastPersonStanding(int personStandingInCircle, int kthPostionPersonDies)
    {
        int result = 0;

        for(int i = 2; i <= personStandingInCircle; i++)
        {
            result = (result + kthPostionPersonDies) % i;            
        }
        Console.WriteLine("last person to survive was on position " + (result+1) + " out of " + 
                personStandingInCircle + " people standing in circle ");        
    }
}
