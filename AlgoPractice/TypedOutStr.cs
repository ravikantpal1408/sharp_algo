using System;

namespace AlgoPractice;

public class TypedOutStr
{
    public void GetTheTypedOutString(string str1, string str2)
    {
        int p1 = str1.Length - 1;
        int p2 = str2.Length - 1;

        while (p1 >= 0 || p2 >= 0)
        {
            if (str1[p1] == '#' || str2[2] == '#')
            {
                if (str1[p1] == '#')
                {
                    var backCount = 2; // pointer required to omit the characters
                    while (backCount > 0)
                    {
                        p1--;
                        backCount--;
                        if (str1[p1] == '#')
                        {
                            backCount = backCount + 2;
                        }
                    }
                }
                if (str2[p2] == '#')
                {
                    var backCount = 2;
                    while (backCount > 0)
                    {
                        p1--;
                        backCount--;
                        if (str2[p2] == '#')
                        {
                            backCount = backCount + 2;
                        }
                    }
                }
            }
            else
            {
                if (str1[p1] != str1[p2])
                {
                    Console.WriteLine($"the given string are not equal");
                }
                else
                {
                    p1--;
                    p2--;
                }
            }


        }

        Console.WriteLine($"given string after changes are equal");

    }

}
