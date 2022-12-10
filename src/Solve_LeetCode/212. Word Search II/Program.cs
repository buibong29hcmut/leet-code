public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        HashSet<string>result = new HashSet<string>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                for(int k = 0; k < words.Length; k++)
                {
                    char[] check = new char[words[k].Length];
                    Search(board, 0, i, j, words[k], check);
                    string checkString = new string(check);
                    if (checkString == words[k])
                    {
                        if (!result.Contains(checkString))
                        {
                            result.Add(checkString);
                        }
                    }
                }
           
            }
        }
        if (result.Count == 0)
        {
            return new List<string>();  
        }
        return result.ToList();

    }
    void Search(char[][] board, int indextarget, int row, int col, string wordTarget, char[] check)
    {
        if (row == board.Length || col == board[0].Length || indextarget == check.Length || row < 0 || col < 0 || board[row][col] != wordTarget[indextarget])
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
        Solution solution = new Solution();
       var result= solution.FindWords(new char[][]
        {
            new char[] {'a','b'},
            new char[] {'b','c'},
        }, new[] {"abcb"});
        foreach(var item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
        
    }
}