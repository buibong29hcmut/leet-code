public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int len= numbers.Length;
        int right = len-1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return new[] { left+1, right+1 };
            }
            if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
        }
        return new[] { -1, -1 };
    }
}
