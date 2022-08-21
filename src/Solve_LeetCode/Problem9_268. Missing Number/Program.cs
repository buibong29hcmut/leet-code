int missingNumber(int[] nums)
{
    Array.Sort(nums);
    int ans = 0;
    for(int i=0;i<nums.Length; i++)
    {
        if (nums[i] == ans)
            ans++;
    }
    return ans;
}
