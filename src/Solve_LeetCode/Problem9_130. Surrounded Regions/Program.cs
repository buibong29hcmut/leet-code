public class Solution
{
    public void Solve(char[][] board)
    {
        if (board == null || board.Length == 0)
            return;
        if (board.Length < 3 || board[0].Length < 3)
            return;
        int lenRow= board.Length;
         int lenCol= board[0].Length;
         for(int i=0; i<lenRow; i++)
        {
            if(board[i][0]=='O')
            {
                Dfs(board, i, 0);
            }
            if (board[i][lenCol - 1]=='O')
            {
                Dfs(board, i, lenCol-1);

            }
        }
        for(int i=0; i<lenCol; i++)
        {
            if (board[0][i] == 'O')
            {
                Dfs(board, 0, i);

            }
            if (board[lenRow-1][i] == 'O')
            {
                Dfs(board, lenRow-1, i);

            }
        }
        for(int i = 0; i < lenRow; i++)
        {
            for(int j = 0; j < lenCol; j++)
            {
                if (board[i][j] == 'O')
                    board[i][j] = 'X';
                if (board[i][j] == '+')
                    board[i][j] = 'O';
            }
        }
    }
    public void Dfs(char[][] board, int row, int col)
    {
        if (row < 0 || col < 0 || row > board.Length - 1 || col > board[0].Length - 1 || board[row][col] != 'O')
            return;
        board[row][col] = '+';
        Dfs(board, row + 1, col);
        Dfs(board, row - 1, col);
        Dfs(board, row, col - 1);
        Dfs(board, row, col + 1);
    }
    
}
