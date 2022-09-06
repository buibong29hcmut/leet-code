public class NumMatrix
{
    private int[][] MatrixInitial { get;  set; }
    public NumMatrix(int[][] matrix)
    {
        for(int i=0; i < matrix.Length; i++)
        {
            for(int j=1; j < matrix[0].Length; j++)
            {
                matrix[i][j] += matrix[i][j - 1];
            }
        }
        MatrixInitial= matrix;
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        int result = 0;
        for(int row = row1; row <=row2; row++)
        {
            result += MatrixInitial[row][col2];
            if (col1 > 0)
            {
                result = result - MatrixInitial[row][col1 - 1];
            }
        }
        return result;
    }
}
