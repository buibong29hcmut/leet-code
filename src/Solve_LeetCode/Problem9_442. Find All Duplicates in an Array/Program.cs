public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        Dictionary<int, int> check = new();
        List<int> result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (check.ContainsKey(nums[i]))
            {
              
                int count = check[nums[i]]; 
                check[nums[i]] = count + 1;
              
                continue;
              
                
            }
            check.Add(nums[i], 1);
        }
        foreach(var key in check.Keys)
        {
            if (check[key] == 2)
                result.Add(key);
        }
        return result;
    }
}
