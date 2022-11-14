public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = -1;
        HashSet<int> visited = new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (!visited.Contains(nums[i]))
            {
                result = nums[i];   
                visited.Add(nums[i]);
                continue;
            }
            result = -1;

        }
        return result;
        
    }
    public static void Main()
    {
        int result = new Solution().SingleNumber(new[] { 2, 2, 3, 2 });
        Console.WriteLine(result);
    }
}
