using System;
using System.Collections.Generic;

namespace AlgoPractice;

public class TwoSum
{

    public static void FindTwoSumWithTargetValue(int[] listOfNumbers, int targetValue)
    {
        Dictionary<int, int> keyValuePairs = new ();

         
        for(int i = 0; i< listOfNumbers.Length; i++)
        {
            int complement = targetValue - listOfNumbers[i];

            if(keyValuePairs.ContainsKey(complement))
            {
                Console.WriteLine($"[{listOfNumbers[i]}, {complement}]");
            }
            
            keyValuePairs[listOfNumbers[i]] = i;
        }
    }

}
