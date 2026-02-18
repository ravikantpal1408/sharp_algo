using System;

namespace AlgoPractice;

public class CharCounter
{
    public static void GetCharCounter(string str)
    {
        Dictionary<char, int> result = new ();

        for(int i=0; i< str.Length; i++)
        {
            if(result.ContainsKey(str[i]))
            {
                
                result[str[i]]=result[str[i]]+1;
            }
            else
            {
                result[str[i]] = 1;
            }
        }

        foreach(var k in result)
        {
            Console.WriteLine($" [{k.Key.ToString()} , {k.Value.ToString()}]");
        }
    }
}
