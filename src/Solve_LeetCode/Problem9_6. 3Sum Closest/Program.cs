public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);

        int result = 0;
        int minsum = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                int range = Math.Abs(sum - target);
                if (range == 0)
                {
                    result = sum;
                    return result;
                }
                if (minsum != Math.Min(minsum, range))
                {
                    result = sum;
                    minsum = Math.Min(minsum, range);

                }
                if (sum > target)
                {
                    right--;


                }
                if (sum < target)
                {
                    left++;
                }


            }
        }
        return result;
    }
}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.ThreeSumClosest(new[] { 1,1,1,1,1 },3));

    }
}