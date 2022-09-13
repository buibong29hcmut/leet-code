public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        for(int i = 0; i < obstacleGrid.Length; i++)
        {
            for(int j = 0; j < obstacleGrid[0].Length; j++)
            {
                //if (i == 0&& obstacleGrid[i][j]==0)
                //{
                //    obstacleGrid[i][j] = 1;
                //}
                //if (j == 0 && obstacleGrid[i][j] == 0)
                //{
                //    obstacleGrid[i][j] = 1;

                //}
                if(obstacleGrid[i][j] == 0)
                {
                    obstacleGrid[i][j] = 1;
                }
                else
                {
                    obstacleGrid[i][j] = 0;
                }
              
            }
        }
        for(int i = 1; i < obstacleGrid.Length; i++)
        {
            for(int j = 1; j < obstacleGrid.Length; j++)
            {
                if (obstacleGrid[i][j] == 0)
                    continue;
                obstacleGrid[i][j] = obstacleGrid[i - 1][j] + obstacleGrid[i][j-1];
            }
        }
        return obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];
    }
}
public class Program
{
    public static void Main()
    {
        int[][] arr = new int[][]
        {
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{0,0,0},
        };
        Console.WriteLine(new Solution().UniquePathsWithObstacles(arr));
    }
}