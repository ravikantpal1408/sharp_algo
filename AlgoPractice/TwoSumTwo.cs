using System;

namespace AlgoPractice;

public class TwoSumTwo
{
    public static void GetSortedTwoSumTwo(int[] list, int target)
    {
        int left = 0; int right = list.Length -1; 
        while(left<right)
        {
            int sum = 0;

            sum = list[left] + list[right];
            if(sum == target)
            {
                Console.WriteLine($" taget sum : {target} found at index {left} and {right} : {list[left]} , list{right} respectively");
                break;
            }
            
            if(sum<target)
            {
                left++;
            }
            else
            {
                right--;
            }
            
            
        }
    }

}
