public class Solution
{
    int RemoveDuplicates(int[] nums)
    {
        int count = 1;
        int appear = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[count] == nums[appear])
            {
                if (appear == 1)
                {
                    nums[count] = nums[i];
                    count++;
                    appear++;
                }

                else if (appear == 2)
                    continue;
            }
            else
            {
                nums[count] = nums[i];
                count++;
                appear = 1;
            }
            
        }
        return count;
    }
}
