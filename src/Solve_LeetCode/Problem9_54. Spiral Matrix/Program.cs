public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new();
        bool[,] matrixClone = new bool[matrix.Length,matrix[0].Length];
        int moveRight = 0;
        int moveDown = 1;
        int moveLeft =2;
        int moveUp = 3;
        int moveNext = 0;
        int row = 0;
        int col = 0;
        result.Add(matrix[row][col]);
        matrixClone[0, 0] = true;


        while (result.Count<matrix.Length* matrix[0].Length)
        {
            if (moveNext == moveRight)
            {
                while ((col < matrix[0].Length - 1 && matrixClone[row, col + 1] == false) )
                { 
                    col++;
                    matrixClone[row, col] = true;
                    result.Add(matrix[row][col]);
                    if (col == matrix[0].Length - 1)
                    {
                      
                        break;
                    }

                }




            }
            else if (moveNext == moveDown)
            {
                while ((row < matrix.Length - 1 && matrixClone[row + 1, col] == false) )
                {
                   
                    row++;
                    result.Add(matrix[row][col]);
                    matrixClone[row, col] = true;
                    if (row == matrix.Length - 1)
                    {


                        break;
                    }

                }


            }
            else if (moveNext == moveLeft)
            {
                while ((col > 0 && matrixClone[row, col - 1] == false) )
                {
                 
                    col--;
                    matrixClone[row, col] = true;
                    result.Add(matrix[row][col]);
                    if (col == 0)
                    {
                     

                        break;
                    }


                }


            }
         else   if (moveNext == moveUp)
            {
                while ((row >0 && matrixClone[row-1,col]==false))
                {
                   
                    row--;
                    result.Add(matrix[row][col]);
                    matrixClone[row, col] = true;
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

        Solution solution = new Solution();
        int[][] matrix = new int[][]
        {
            new []{ 1,2,3},
           new[]  {3,5,4},
           new[] {7,8,9},
        };
    var result=    solution.SpiralOrder(matrix);
        Console.ReadLine();


    }

}

