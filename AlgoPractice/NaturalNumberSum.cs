using System;

namespace AlgoPractice;

public class NaturalNumberSum
{
    public int findSumUsingRecursion(int n)
    {
        if(n == 0) {
            return n;
        }

        return (n + findSumUsingRecursion(n-1));
    }
}
