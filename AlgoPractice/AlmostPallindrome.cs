namespace AlgoPractice;


public class AlmostPallindrome
{
    public static bool AlmostPallindromeCheck(string str)
    {
        // this is the optimal solution
        int left=0; int right = str.Length -1;

        while(left < right)
        {
            if(str[left] != str[right])
            {
                return ValidSubPallindrome(str, left, right) ||  ValidSubPallindrome(str, left, right - 1);
            }

            left++;
            right--;
        }

        return true;
    }

    public static bool ValidSubPallindrome(string originalStr,int left,int right)
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
