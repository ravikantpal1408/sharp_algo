namespace AlgoPractice;


public class AlmostPalindrome
{
    public static bool AlmostPalindromeCheck(string str)
    {
        // this is the optimal solution
        int left=0; int right = str.Length -1;

        while(left < right)
        {
            if(str[left] != str[right])
            {
                return ValidSubPalindrome(str, left, right) ||  ValidSubPalindrome(str, left, right - 1);
            }

            left++;
            right--;
        }

        return true;
    }

    private static bool ValidSubPalindrome(string originalStr,int left,int right)
    {
        while(left < right)
        {
            if(originalStr[left] != originalStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
