void SetZeroes(int[][] matrix)
{
    Dictionary<int,HashSet<int>> result = new Dictionary<int, HashSet<int>>();
    for(int i= 0; i < matrix.Length; i++)
    {
        for(int j=0; j < matrix[0].Length; j++)
        {
            if(matrix[i][j] == 0)
            {
                if (result.ContainsKey(i))
                {
                    if (!result[i].Contains(j))
                        result[i].Add(j);
                }
                else
                {
                    HashSet<int> hash = new HashSet<int>();
                    hash.Add(j);
                    result.Add(i, hash);
                }
            }
        }
    }
    foreach (var rowzero in result.Keys)
    {
        for (int coli = 0; coli < matrix[i].Length; coli++)
        {
            matrix[rowzero][coli] = 0;
        }
        foreach(var col in result[rowzero])
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row][col] = 0;
            }
        }
    }

}

Console.WriteLine("Hello, World!");
