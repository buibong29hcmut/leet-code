public class Solution
{
    public string Tictactoe(int[][] moves)
    {
 
        int[,] matrixA = new int[3, 3];
        int[,] matrixB = new int[3, 3];
        for(int i = 0; i < moves.Length; i++)
        {   int col = moves[i][0];
            int row = moves[i][1];
            if (i % 2 == 0)
            {
                matrixA[row, col] = 1;
                continue;
            }
            matrixB[row, col] = 1;
        }
        if (Check(matrixA))
            return "A"; 
        if (Check(matrixB))
            return "B";
        return moves.Length == 9 ? "Draw" : "Pending";
       
    }
    private bool Check(int[,] moves)
    {
        for (int i = 0; i < 3; i++)
        {
            if (moves[0,i] == 1&& moves[1,i] ==1&& moves[2,i] == 1)
                return true;
            if (moves[i,0] == 1&& moves[i,1] ==1 && moves[i,2] == 1)
                return true;
        }
        if (moves[0,0] == 1 && moves[1,1] == 1 && moves[2,2] == 1)
            return true;
        if (moves[0,2] == 1 && moves[1,1] == 1 && moves[2,0] == 1)
            return true;
        return false;
    }
}