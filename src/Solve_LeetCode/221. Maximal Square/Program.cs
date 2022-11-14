public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {  
        int[,] dp = new int[matrix.Length,matrix[0].Length];
        int row = matrix.Length;
        int col = matrix[0].Length;
        int max = 0;
        for(int i = 0; i < col;i++)
        {
            dp[0,i] = matrix[0][i]-'0';
        }
        for(int i = 1; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                dp[i,j] = dp[i - 1,j] + matrix[i][j]-'0';
            }
        }
        for(int i = 0; i <row; i++)
        {
            for(int j = 0; j<col; j++)
            {
                int mincol = dp[i,j];
                max = Math.Max(mincol, max);
                for (int k = j+1; k < col; k++)
                {
                    mincol = Math.Min(dp[i,k], mincol);
                    max = Math.Max(mincol * ((k - j)), max);
                }
            }
        }
        return max;
    }
  
}
