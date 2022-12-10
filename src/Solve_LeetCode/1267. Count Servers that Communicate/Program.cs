public class Solution
{
    public int CountServers(int[][] grid)
    {
        int[] rows= new int[grid.Length];
        int[] cols= new int[grid[0].Length];
        int result = 0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j = 0; j < grid[i].Length;j++)
            {
                if (grid[i][j]==1)
                {
                    rows[i]++;
                    cols[j]++;
                }    
            }
        }
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1&& (rows[i]>1|| cols[j]>1))
                {
                    result++;
                }
            }
        }
        return result;
    }
}
