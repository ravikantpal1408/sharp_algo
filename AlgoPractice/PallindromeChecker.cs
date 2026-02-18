using System;

namespace AlgoPractice;

public class PallindromeChecker
{

    public static void CheckForPallindrome(string str)
    {
        int p1=0, p2=str.Length-1;
        bool isPallindrome = true;        
        
        while(p1<=p2)
        {
            if(str[p1] != str[p2])
            {
                isPallindrome=false;
                Console.WriteLine($"Given string {str} is not pallindrome");
                break;
            } 
            
            p1++;
            p2--;            
            
        }
        if(isPallindrome) Console.WriteLine($"Given string {str} is pallindrome");
        
    }

}
