public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int count=0;
      
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] !=val)
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }

}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        solution.RemoveElement(new[] { 1 }, 1);
    }
}