using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> result = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++) 
        {
            if (result.ContainsKey(nums[i]))
            {
                result[nums[i]]++;
            }
            result.Add(nums[i],1);
        }
       return result.OrderByDescending(p => p.Value).Select(p=>p.Value).Skip(k).ToArray();
    }
}
