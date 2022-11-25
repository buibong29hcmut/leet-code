public class Solution
{
    public int RemoveStones(int[][] stones)
    {
        HashSet<int> colVisited = new HashSet<int>();
        HashSet<int> rowVisited = new HashSet<int>();
        int result=0;
        for(int i=0;i<stones.Length;i++)
        {
            if (!rowVisited.Contains(stones[i][0]))
            {
                rowVisited.Add(stones[i][0]);
            }
            else 
            {
                result++;
                if (!colVisited.Contains(stones[i][1]))
                {
                    colVisited.Add(stones[i][1]);
                    continue;

                }
                continue;

            }
             if (colVisited.Contains(stones[i][0]))
            {
                result++;
             
             }
          


        }
        return result;
    }
}

