namespace Patterns;

public static class Program
{
    public static void Main(String[] args)
    {
        PatternOne(5);
        Console.WriteLine();
        PatternTwo(5);
    }


    private static void PatternOne(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void PatternTwo(int n)
    {
        for (int i = n; i > 0; i--)
        {
            for (int j = 0; j < i-1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void PatternThree(int n)
    {
        for (int i = n; i > 0; i--)
        {
            for (int j = 0; j < i-1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i-1; k++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}


