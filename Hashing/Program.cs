namespace Hashing;

public class Program
{
    public static void Main(string[] args)
    {
        // Automatically sorts keys in ascending order
        SortedDictionary<int, string> treeMapEquivalent = new();

        treeMapEquivalent.Add(3, "Apple");
        treeMapEquivalent.Add(1, "Banana");
        treeMapEquivalent.Add(2, "Cherry");

        // Output will be ordered by key: 1, 2, 3
        foreach (var kvp in treeMapEquivalent)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}