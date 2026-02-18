namespace AlgoPractice;


public class AlmostPallindrome
{
    public static void AlmostPallindromeCheck(string str)
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

    public bool ValidSubPallindrome(originalStr, left, right)
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
