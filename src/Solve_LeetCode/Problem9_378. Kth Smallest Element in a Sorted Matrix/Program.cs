public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int result = 0;
        int col = matrix[0].Length - 1;
        int row = matrix.Length - 1;
        int n = (col + 1) * (row + 1);
        List<int> list = new List<int>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                list.Add(matrix[i][j]);
            }
        }
        list.Sort();
        return list[k - 1];
    }

}