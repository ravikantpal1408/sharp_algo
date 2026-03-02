using System;

namespace AlgoPractice;

public class PalindromeChecker
{

    public static void CheckForPalindrome(string str)
    {
        int p1=0, p2=str.Length-1;
        bool isPalindrome = true;        
        
        while(p1<=p2)
        {
            if(str[p1] != str[p2])
            {
                isPalindrome=false;
                Console.WriteLine($"Given string {str} is not pallindrome");
                break;
            } 
            
            p1++;
            p2--;            
            
        }
        if(isPalindrome) Console.WriteLine($"Given string {str} is pallindrome");
        
    }

}
