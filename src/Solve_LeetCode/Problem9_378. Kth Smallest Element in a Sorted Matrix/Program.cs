public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
      
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