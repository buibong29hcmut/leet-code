public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            List<int> items = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                int item = 1;
                if (i > 1 && j > 0 && j < i)
                {
                    item = result[i - 1][j - 1] + result[i - 1][j];
                }
                items.Add(item);
            }
            result.Add(items);
        }
        return result;


    }
}