public class Solution
{
    public int MaxPoints(int[][] points)
    {
        int max = 1;
        for(int i = 0; i < points[0].Length; i++)
        {   int count = 0;
            for(int j = 0; j < points[0].Length; j++)
            {
                if (i == j)
                    continue;
                if ((double)points[0][i] / points[0][j]== (double)points[1][i] / points[1][j])
                {
                    count++;
                }
            }
            max = Math.Max(max, count);
        }
        return max;
    }
}
