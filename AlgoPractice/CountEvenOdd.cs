using System;

namespace AlgoPractice;

public class CountEvenOdd
{
    public static void GetCountOfEvenOdd(int[] arr)
    {
        Dictionary<string, int> result = new ();
        result.Add("even", 0);
        result.Add("odd", 0);

        for(int i=0; i< arr.Length; i++)
        {
            if (arr[i] % 2 == 0 && result.ContainsKey("even")) 
            {
                
                result["even"] = result["even"]+1;
            }
            else
            {
                result["odd"] = result["odd"]+1;
            }
        }

        foreach(var k in result)
        {
            Console.WriteLine($"{k.Key} : {k.Value}");
        }
    }
}
