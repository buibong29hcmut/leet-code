public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (result.ContainsKey(nums[i]))
            {
                result[nums[i]] += 1;
                continue;
            }
            result.Add(nums[i], 1);
        }
        foreach (var item in result.Keys)
        {
            if (result[item] == 1)
                return item;
        }
        return 0;
    }
}
