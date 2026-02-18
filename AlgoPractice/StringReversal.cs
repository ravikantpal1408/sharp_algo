using System;

namespace AlgoPractice;

public class StringReversal
{
    public static void GetReversedString(string str)
    {
        string revStr = string.Empty;

        for(int i=str.Length-1; i>=0; i--)
        {
            revStr += str[i];   
        }

        Console.WriteLine($"Original String : {str}, reversed string : {revStr}");
    }

}
