public class Solution
{
    
    public int[][] ColorBorder(int[][] grid, int row, int col, int color)
    {
        bool[,] visited = new bool[grid.Length, grid[0].Length];
         var result = grid;
        Dfs( result, visited, row, col, color, grid[row][col]);
        return result;
    }
    public void Dfs( int[][]grid, bool[,] visited,int row, int col, int color, int val)
    {
        if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || visited[row, col] == true || grid[row][col] != val)
            return;
        if (grid[row][col] == val && visited[row,col]==false)
        {
            visited[row,col] = true;
                grid[row][col] = color;   
            Dfs( grid, visited, row + 1, col, color, val);
            Dfs( grid, visited, row-1, col, color, val);
            Dfs( grid, visited, row, col+1, color, val);
            Dfs( grid, visited, row, col-1, color, val);

        }
    }
}
public class Program
{
    public static void Main()
    {
        int[][] a = new int[][]
        {
           new int[]{1,2,2},
           new int[]{2,3,3},
        };
        Solution s= new Solution();
        s.ColorBorder(a, 0, 1, 3);
    }
}
