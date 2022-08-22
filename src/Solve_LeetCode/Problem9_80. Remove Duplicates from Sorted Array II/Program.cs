
int RemoveDuplicates(int[] nums)
{
    int count = 0;
    for(int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == nums[i - 1])
        {
            nums[i - 1] = nums[i];
            count++;
        }
    }
    return count;
}
Console.WriteLine("Hello, World!");
