public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int[,] dp= new int[obstacleGrid.Length, obstacleGrid[0].Length];
        if (obstacleGrid == null || obstacleGrid.Length == 0)
            return 0;
        for (int i = 0; i < obstacleGrid[0].Length; i++)
        {
            if (obstacleGrid[0][i] == 0)
            {
                dp[0, i] = 1;

            }
            else
                break;
        }
        for (int i = 0; i < obstacleGrid.Length; i++)
        {
            if (obstacleGrid[i][0] == 0)
            {
                dp[i, 0] = 1;

            }
            else
            {
                break;
            }
        }
        for(int i = 1; i < obstacleGrid.Length;i++)
        {
            for(int j = 1; j < obstacleGrid[0].Length; j++)
            {
                if (obstacleGrid[i][j] == 0)
                {
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, j];

                }
            }
        }
        return dp[obstacleGrid.Length-1,obstacleGrid[0].Length-1];
    }
}
public class Program
{
    public static void Main()
    {
        int[][] arr = new int[][]
        {    new int[]{1,0}
            //new int[]{0,0,0},
            //new int[]{0,1,0},
            //new int[]{0,0,0},
        };
        Console.WriteLine(new Solution().UniquePathsWithObstacles(arr));
    }
}