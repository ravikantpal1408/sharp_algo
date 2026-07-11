namespace Hashing;

public abstract class Program
{
    public static void Main(string[] args)
    {
        // Automatically sorts keys in ascending order
        // SortedDictionary<int, string> treeMapEquivalent = new();

        // treeMapEquivalent.Add(3, "Apple");
        // treeMapEquivalent.Add(1, "Banana");
        // treeMapEquivalent.Add(2, "Cherry");
        //
        // // Output will be ordered by key: 1, 2, 3
        // foreach (var kvp in treeMapEquivalent)
        // {
        //     Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        // }

        HashingArrOps.DoTheArrayHashOps();
    }


    private class HashingArrOps
    {
        public static void DoTheArrayOps()
        {
            int[] arr = [5, 6, 5, 6, 9, 6];
            var count = 0;
            foreach (var num in arr)
            {
                if (num == 6)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
        
        public static void DoTheArrayHashOps()
        {
            var arr = new int[5, 6, 5, 6, 9];
            var hashTable = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                hashTable[i]++;
            }
            Console.WriteLine(hashTable[6]);
            
            
        }
    }
}