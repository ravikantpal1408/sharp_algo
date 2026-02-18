using System;

namespace AlgoPractice;

public class TrappingRainWater
{
    /*
        currentWater = min(maxLeft, maxRight) - currentHeight
        
    */
    public static void MaxTrapperWater(int[] listOfHeights)
    {
        int left=0, right=listOfHeights.Length-1, maxLeft=0, maxRight=0, totalWater = 0;

        while(left < right)
        {
            if(listOfHeights[left] <= listOfHeights[right])
            {
                if(listOfHeights[left] >= maxLeft )
                {
                    maxLeft = listOfHeights[left];
                } 
                else
                {
                    totalWater += maxLeft - listOfHeights[left];    
                }
                left++;
            }
            else
            {
                if(listOfHeights[right]>=maxRight)
                {
                    maxRight = listOfHeights[right];
                }
                else
                {
                    totalWater += maxRight - listOfHeights[right];
                }

                right--;
            }

        }

        Console.WriteLine($"Max water trapped = {totalWater}");
    }
}
