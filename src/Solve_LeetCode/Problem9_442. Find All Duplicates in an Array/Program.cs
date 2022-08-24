public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        Dictionary<int, int> check = new();
        HashSet<int> result = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (check.ContainsKey(nums[i]))
            {
                if (check[nums[i]] >= 2)
                {
                    result.Remove(nums[i]);
                    continue;
                }
                int count = check[nums[i]]; 
                check[nums[i]] = count + 1;
                if (check[nums[i]] == 2)
                {
                    result.Add(nums[i]);
                    continue;
                }
                continue;
              
                
            }
            check.Add(nums[i], 0);
        }
        return result.ToList();
    }
}
