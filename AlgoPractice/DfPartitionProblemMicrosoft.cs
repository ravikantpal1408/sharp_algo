using System;

namespace AlgoPractice;

public class DfPartitionProblemMicrosoft
{
    /*
    You are given a list of integers representing complexity values of tasks and an integer days.

    You need to schedule all tasks in the given order over exactly days days.
    Rules:
        Each day must have at least one task.
        Tasks assigned to a day must be contiguous.
        The complexity of a day is defined as the maximum complexity of the tasks done on that day.
        The total complexity is the sum of daily complexities.
    Goal:
        Find the minimum total complexity possible.
        If it is not possible to schedule the tasks over the given number of days, return -1.
    
    */
    public static int findMinComplexity(List<int> complexity, int days)
    {
        int n = complexity.Count;
        if (n < days) return -1;

        long INF = (long)1e18;

        long[] prev = new long[n + 1];
        long[] curr = new long[n + 1];

        for (int i = 0; i <= n; i++)
            prev[i] = INF;

        prev[0] = 0;

        for (int d = 1; d <= days; d++)
        {
            for (int i = 0; i <= n; i++)
                curr[i] = INF;

            for (int i = d; i <= n; i++)
            {
                int max = 0;
                for (int k = i; k >= d; k--)
                {
                    max = Math.Max(max, complexity[k - 1]);
                    curr[i] = Math.Min(curr[i], prev[k - 1] + max);
                }
            }

            var temp = prev;
            prev = curr;
            curr = temp;
        }

        return (int)prev[n];
    }

}
