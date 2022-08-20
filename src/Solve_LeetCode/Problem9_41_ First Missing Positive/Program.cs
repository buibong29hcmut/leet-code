 int FirstMissingPositive(int[] nums)
{
    Array.Sort(nums);
    int miss = 1; 
    for(int i = 0; i < nums.Length-1; i++)
    {
        if (nums[i] == miss)
        {
            miss++;
        }
        

    }
    return miss;
}
Console.WriteLine("Hello, World!");
