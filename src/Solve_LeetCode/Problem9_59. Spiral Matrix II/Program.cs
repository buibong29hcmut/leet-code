public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] result = new int[n][];
        int moveRight = 0;
        int moveDown = 1;
        int moveLeft = 2;
        int moveUp = 3;
        int moveNext = 0;
        int row = 0;
        int col = 0;
        int count = 1;
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
        result[0][0] = 1;
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
        while (count < n*n+1)
        {
            if (moveNext == moveRight)
            {
                while ((col < n - 1 && result[row][ col + 1] == 0))
                {
                    col++;
                    count++;
                    result[row][col] = count;

                    if (col == n - 1)
                    {

                        break;
                    }

                }




            }
            else if (moveNext == moveDown)
            {
                while ((row < n-1 && result[row + 1][col] == 0))
                {

                    row++;
                    count++;
                    result[row][col] = count;
                  
                  
                    if (row == n-1)
                    {


                        break;
                    }

                }


            }
            else if (moveNext == moveLeft)
            {
                while ((col > 0 && result[row][col - 1] == 0))
                {

                    col--;
                    count++;
                    result[row][col] = count;
                    if (col == 0)
                    {


                        break;
                    }


                }


            }
            else if (moveNext == moveUp)
            {
                while ((row > 0 && result[row - 1][ col] == 0))
                {

                    row--;
                    count++;
                    result[row][col]=count;          
                    moveNext = -1;



                }



            }

            moveNext++;
        }

        return result;
    }
}

public class Program
{
    public static void Main()
    {
        new Solution().GenerateMatrix(3);
    }
}

