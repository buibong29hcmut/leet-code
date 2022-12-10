public class Solution
{
  
        public int MinIncrementForUnique(int[] nums)
        {
            int result = 0;
            Array.Sort(nums);
            HashSet<int> hash = new HashSet<int>();
            hash.Add(nums[0]);
            int currentMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] == nums[i - 1])
                {
                    result++;
                    nums[i]++;
                    currentMax = nums[i];
                    hash.Add(nums[i]);
                    continue;
                }
                if (hash.Contains(nums[i]))
                {
                    result += currentMax - nums[i] + 1;
                    nums[i] = currentMax + 1;
                    currentMax = nums[i];
                    hash.Add(nums[i]);
                    continue;
                }
            hash.Add(nums[i]);
            }
            return result;
        }
    


}
