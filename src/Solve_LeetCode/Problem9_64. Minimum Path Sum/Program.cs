public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        
        return Calculate(grid,0,0);
    }
    public  int Calculate(int[][] grid,int row,int col)
    {
        if (row == grid.Length  || col ==grid[0].Length)
            return int.MaxValue;
        if (row == grid.Length - 1 && col == grid[0].Length-1)
        {
            return grid[row][col];
        }
        return grid[row][col] + Math.Min(Calculate(grid, row + 1, col), Calculate(grid, row, col + 1));



    }
}
