using System;

namespace LearningSharp;

public class StarPatternPrint
{

    public static void PrintingStarPattern()
    {
        int n = 4;

        for (int i = 1; i <= n; i++)
        {
            // spaces
            for (int s = 1; s <= n - i; s++)
            {
                Console.Write(" ");
            }

            // stars
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }

    public static void PrintingReverseStarPattern()
    {
        int n = 4;

        for (int i = 1; i <= n; i++)
        {
            for (int s = 1; s < i; s++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= n - i + 1; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }

    /*
    
    🎯 PRACTICE TASK (DO THIS)
        Try to print:
        1
        2 3
        4 5 6
        7 8 9 10
        and
        *
        * *
        * * *
        * *
        *

    
    */

}
