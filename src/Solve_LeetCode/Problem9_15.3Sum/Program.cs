 IList<IList<int>> ThreeSum(int[] nums) 
{
    Array.Sort(nums);
    IList<IList<int>> result = new List<IList<int>>();
    HashSet<int> saveNumber=new HashSet<int>();   
    for(int i = 0; i < nums.Length-2; i++)
    {
        int currNum = 0 - nums[i];
        for(int j = i + 1; j < nums.Length; j++)
        {
            if (saveNumber.Contains(currNum - nums[j]))
            {
               
                result.Add(new List<int>() { nums[i], currNum - nums[j], nums[j] });
            }
        }
       saveNumber.Add(nums[i]);
    }
    return result;
}
Console.WriteLine(ThreeSum(new[] { -1, 0, 1, 2, -1, -4 } ));
