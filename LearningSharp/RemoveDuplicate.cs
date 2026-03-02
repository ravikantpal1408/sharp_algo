namespace LearningSharp;

public static class RemoveDuplicate
{

    public static void RemovingDupsNum(int[] n)
    {
        int left = 0; int right = n.Length - 1;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        while(left <= right)
        {
            if(!dict.ContainsKey(n[left]))
            {
                dict.Add(n[left], left);   
                
            }
            left++;    
        }
        Console.Write("[");
        var finalArr = new int[dict.Count];
        left = 0;
        while (left <= dict.Count - 1)
        {
            finalArr[left] = dict.Keys.ToArray()[left];
        }
        Console.Write(finalArr[0].ToString());
        // foreach(var item in dict)
        // {
        //     Console.WriteLine(item.Key + ",");
        //     finalArr[item.] = item.Value;
        // }
        // Console.Write("]");
        
    }

}
