public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        int[] arr = new int[triangle.Count];
        for (int i = 0; i < triangle.Count; i++)
        {
            arr[i] = triangle[triangle.Count - 1][i];
        }
        for (int i = triangle.Count - 2; i >= 0; i--)
        {
            for (int j = 0; j < triangle[i].Count; j++)
            {
                arr[j] = triangle[i][j] + Math.Min(arr[j], arr[j + 1]);
            }
        }
        return arr[0];
    }
}
public class Program { 
    public static void Main()
    {
        Solution solution = new Solution();
        IList<IList<int>> triangle = new List<IList<int>>()
        {
             new List<int>(){2},
                          new List<int>(){3,4},
             new List<int>(){6,5,7},
             new List<int>(){4,1,8,3},

        };
        var result= solution.MinimumTotal(triangle);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

