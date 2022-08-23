public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target) 
    { 
    
        int row = 0;
        int col = matrix[0].Length;
        while (col>0&& row<matrix.Length)
        {
            if (matrix[row][col] > target)
                col--;
            else if (matrix[row][col] < target)
                row++;
            else
                return true;
        }
        return false; 
    }
}
 