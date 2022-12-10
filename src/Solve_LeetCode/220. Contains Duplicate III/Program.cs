public class Solution
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        for(int i=0;i<nums.Length;i++)
        {
            int left = i-indexDiff<0?0:i-indexDiff;
            int right = i + indexDiff;
            for (int j = left; j < nums.Length && j <=i+indexDiff; j++)
            {
                if (j == indexDiff)
                    continue;
                if (Math.Abs(nums[i] - nums[j]) <= valueDiff)
                {
                    return true;
                }

            }
        }
        return false;
    }
}
