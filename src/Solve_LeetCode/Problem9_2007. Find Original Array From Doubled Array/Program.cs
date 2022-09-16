using System.Runtime.InteropServices;

public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        Array.Sort(changed);
        List<int> result = new List<int>();
        Queue<int> check = new Queue<int>();
        for(int i = 0; i < changed.Length; i++)
        {
          if(check.Count!=0 && check.Peek() == changed[i])
            {
                check.Dequeue();
                continue;
            }
            check.Enqueue(changed[i] * 2);
            result.Add(changed[i]); 
            
        }
        return check.Count == 0 ? result.ToArray() :new int[] {};
    }
}
public class Program
{
    public static void Main()
    {
        var arr = new Solution().FindOriginalArray(new[] { 1, 3, 4, 2, 6, 8 });
        foreach(var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}