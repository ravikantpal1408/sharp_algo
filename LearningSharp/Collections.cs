using System;

namespace LearningSharp;

public class Collections
{
    public static void DictionaryEx(int n)
    {
        string s = "hello";
        Dictionary<char, int> map = new();

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }
    }

    /*
        Commonly used methods in LIST 

        list.Remove(20);
        list.Contains(10);
        list.Count;
        list.Sort();
        list.Reverse();

    */
    public static void ListExample(int n)
    {
        List<int> res = new();
        for (int i = 0; i < n; i++)
        {
            res.Add(i);
        }
    }

}
