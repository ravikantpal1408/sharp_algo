using System;

namespace AlgoPractice;

/*
    Longest sub-string without reapeating character (MEDIUM)
*/

public class LongestSubstring
{
    public static void GetLongestContiguousRepeatingString(string str)
    {
        if(str.Length <=1)
        {
            Console.WriteLine($"longest string length = {str.Length}"); 
            return;
        }

        Dictionary<char, int> seenCharacter = new();

        int left = 0; int longest =0;

        for(int right = 0; right < str.Length; right++)
        {
            var currentChar = str[right];

            var prevSeenChar = seenCharacter[currentChar];

            if(prevSeenChar >= left)
            {
                left = prevSeenChar + 1;
            }

            seenCharacter[currentChar] = right;

            longest = Math.Max(longest, right - left + 1);            
        }

        Console.WriteLine($"The longest sub-string = {longest}");
    }
}
