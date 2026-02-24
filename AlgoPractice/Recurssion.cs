using System;

namespace AlgoPractice;

public class Recurssion
{
    public static int RecFactorialPrint(int num)
    {
        if (num == 1)
        {
            return num;
        }
        return num * RecFactorialPrint(num-1);
    }

    public static int Fibonacci(int num)
    {
        if(num <= 1)
        {
            return num;
        }

        return Fibonacci(num -1) + Fibonacci(num-2);
    }
    
}
