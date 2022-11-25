using System.Linq;

public class Solution
{
    public int[] SingleNumber(int[] nums)
    {

        Dictionary<int, int> saveResult = new Dictionary<int, int>();
        List<int> result = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!saveResult.ContainsKey(nums[i]))
            {
                saveResult.Add(nums[i],1);
                continue;
            }
            saveResult[nums[i]] = saveResult[nums[i]] + 1;
          

        }
        foreach(var key in saveResult.Keys)
        {
            if (saveResult[key] == 1)
            {
                result.Add(key);
            }
        }
        return result.ToArray();
    }
}
