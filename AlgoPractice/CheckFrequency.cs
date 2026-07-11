namespace AlgoPractice;

public class CheckFrequency
{
   
   public void CheckForFrequency(int[] arr)
   {
      var maxFreq = 0;
      var secMaxFreq = 0;
      
      Dictionary<int, int> dict = new Dictionary<int, int>();
      foreach (var item in arr)
      {
         if (dict.ContainsKey(item))
         {
            dict[item]++;
         }
         else
         {
            dict.Add(item, 1);
         }
      }

      foreach (var k in dict.Keys)
      {
         if (k > maxFreq)
         {
            maxFreq = k;
         }
         
      }


   } 
}