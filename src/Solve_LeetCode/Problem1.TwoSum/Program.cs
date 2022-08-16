int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> save = new Dictionary<int, int>();
    for(int i = 0; i < nums.Length; i++)
    {
       
        if (save.ContainsKey(target - nums[i]))
            return new[] { save[target - nums[i]], i };
        if (save.ContainsKey(nums[i]))
            continue;
        save.Add(nums[i], i);
    }
  
    return new[] {-1,-1}  ;
}
int[] items = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
var result = TwoSum(items, 11);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);

