using System;

namespace AlgoPractice;

public class ClosestNumber
{
    // num = 13 ; divisible = 4
    public static int ReturnTheClosestTarget(int num, int divisible)
    {
        int closest = 0; 
        int minDifference = int.MaxValue;

        // i = 9 i <=  13+4= 17 ; 10
        for(int i = num - Math.Abs(divisible); i <= num + Math.Abs(divisible) ; ++i )
        {
            // 10%9 == 0 ? no
            if(i % divisible == 0)
            {
                int diff = Math.Abs(num -i);

                if(diff < minDifference || (diff == minDifference && Math.Abs(i) > Math.Abs(closest)))
                {
                    closest = i;
                    minDifference = diff;
                }
            }
        }
        return closest;
    }
}
