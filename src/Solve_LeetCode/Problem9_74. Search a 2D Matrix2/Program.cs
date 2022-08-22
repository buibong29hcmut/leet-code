public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {

        return Search(matrix, 0, matrix[0].Length - 1, target);
    }
    bool Search(int[][] maxtrix, int row, int col, int target)
    {
        if (row > maxtrix.Length - 1 || col > maxtrix[0].Length - 1 || col < 0)
        {
            return false;
        }
        if (maxtrix[row][col] < target)
        {
            return Search(maxtrix, row + 1, col, target);

        }
        else if (maxtrix[row][col] > target)
        {
            return Search(maxtrix, row, col - 1, target);

        }
        else
        {
            return true;

        }


    }
}
