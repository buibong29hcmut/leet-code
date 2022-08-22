public class Solution
{

    public bool Exist(char[][] board, string word)
    {
        char[] check = new char[word.Length];
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                Search(board, 0, i, j, word, check);
                if (new string(check) == new string(word))
                    return true;
            }
        }
        return false;
    }
    void Search(char[][] board, int indextarget, int row, int col, string wordTarget, char[] check)
    {
        if (row == board.Length || col == board[0].Length|| indextarget==check.Length|| row<0||col<0|| board[row][col] != wordTarget[indextarget])
            return;
        else
        {
                check[indextarget] = board[row][col];
                board[row][col] = '#';
            Search(board, indextarget + 1, row, col + 1, wordTarget, check);
            Search(board, indextarget + 1, row, col - 1, wordTarget, check);
            Search(board, indextarget + 1, row + 1, col, wordTarget, check);
            Search(board, indextarget + 1, row - 1, col, wordTarget, check);
            board[row][col] = check[indextarget];


        }

    }
    public static void Main()
    {
        var chars = new char[][] { new char[] { 'A', 'B', 'C', 'E' },new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
        Console.WriteLine(new Solution().Exist(chars, "ABCCED"));
    }
}
