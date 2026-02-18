using System;

namespace AlgoPractice;

public class ContainerWithMostWater
{
    public static void GetAreaWithMostWater(int[] listNumArry)
    {
        int left = 0; int right = listNumArry.Length-1; 

        int maxArea = 0;


        while(left<right)
        {
            int height = Math.Min(listNumArry[left], listNumArry[right]);
            int width = right - left;

            int current_area = height * width;

            maxArea = Math.Max(maxArea, current_area);

            if(listNumArry[left] <= listNumArry[right])
            {
                left++;
            } 
            else
            {
                right--;    
            }
            
        }

        Console.WriteLine($" Max area is : {maxArea}");
    }


}
