using System;

namespace AlgoPractice;

public class NaturalNumberSum
{
    public int FindSumUsingRecursion(int n)
    {
        if(n == 0) {
            return n;
        }

        return (n + FindSumUsingRecursion(n-1));
    }
}
