public class Solution
{
    public int GetMaximumGold(int[][] grid)
    {
        int max = 0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j = 0; j < grid[i].Length;j++)
            {
                max = Math.Max(max, GetMaximumGoldDfs(grid, i, j));
            }
        }
        return max;
    }
    private int[] DIR = new int[] { 0, 1, 0, -1, 0 };
    public int GetMaximumGoldDfs(int[][] grid, int rowStart, int colStart)
    {
        if ( rowStart < 0 || colStart < 0|| rowStart==grid.Length || colStart ==grid[0].Length|| grid[rowStart][colStart] == 0)
            return 0;
        int val = grid[rowStart][colStart];
        grid[rowStart][colStart] = 0;
        int max = 0;
        for(int i=0;i<4;i++)
        {
           max= Math.Max(GetMaximumGoldDfs(grid, rowStart + DIR[i], colStart + DIR[i+1]),max);    
        }
        grid[rowStart][colStart] = val;
        return val + max;
    }
}
