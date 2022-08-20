bool IsValidSudoku(char[][] board)
{
    bool result = true;
    HashSet<char> boardSet3 = new HashSet<char>();
    HashSet<char> boardSet4 = new HashSet<char>();

    for (int i = 0; i < 9; i++)
    {   HashSet<char> boardSet = new HashSet<char>();
        HashSet<char> boardSet2 = new HashSet<char>();

        for(int j = 0; j < 9; j++)
        {
            if (board[i][j] != '.')
            {
                if (boardSet.Contains(board[i][j]))
                    return false;
            }
            if (board[j][i]!= '.')
            {
                boardSet.Add(board[i][j]);
                if (boardSet.Contains(board[j][i]))
                    return false;
                boardSet.Add(board[j][i]);

            }

            if (i == j && board[j][i] != '.')
            {
                if (boardSet3.Contains(board[i][j]))
                    return false;
                boardSet3.Add(board[i][j]);
            }
            if (i + j == 8 && board[i][j] != '.')
            {
                if (boardSet4.Contains(board[i][j]))
                    return false;
                boardSet4.Add(board[i][j]); 
            }
        }

    }

    return true ;
}
Console.WriteLine("Hello, World!");
