
using System;

public class Solution
{
    public bool isToeplitzMatrix(int[][] matrix)
    {
        for (int i = 0; i + 1 < matrix.Length; ++i)
            for (int j = 0; j + 1 < matrix[0].Length; ++j)
                if (matrix[i][j] != matrix[i + 1][j + 1])
                    return false;
        return true;
    }
}