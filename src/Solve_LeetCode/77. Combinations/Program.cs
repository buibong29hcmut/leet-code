public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> result= new List<IList<int>>();
        int[] arr = new int[k];
        bool[] flags= new bool[n+1];
        arr[0] = 0;
        Dfs(arr,flags, 1, n, k, result);
        return result;
    }
    public void Dfs(int[] arr, bool[] flags, int index,int n,int k,IList<IList<int>> result)
    {
        if (index == k)
            return;
        for(int j = arr[index-1]+1; j<=n;j++)
        {
            if (flags[j]==false)
            {
                arr[index] = j;
                if (index == k - 1)
                {
                    result.Add(new List<int>(arr));
                    continue;
                }
                flags[j] = true;
                Dfs(arr, flags, index + 1, n, k, result);
                flags[j] = false;    
                
            }
        }

    }
}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.Combine(4, 2);
        foreach(var item in result)
        {
            foreach(var i in item)
            {
                Console.Write(i + " ");
            }
           
        }
        Console.ReadLine();
    }
}
