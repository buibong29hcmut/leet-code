public class Solution
{
    public int SingleNumber(int[] nums)
    {
       
        HashSet<int> visited = new HashSet<int>();
        HashSet<int> saveResult= new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (!visited.Contains(nums[i]))
            {
                saveResult.Add(nums[i]);
                visited.Add(nums[i]);
                continue;
            }
            saveResult.Remove(nums[i]);
            
        }
        return saveResult.FirstOrDefault();
        
    }

}
