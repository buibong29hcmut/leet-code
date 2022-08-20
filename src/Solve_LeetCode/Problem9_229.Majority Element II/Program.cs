IList<int> MajorityElement(int[] nums)
{
    int times = nums.Length / 3;
    List<int> result = new List<int>();
    Dictionary<int, int> hash = new();
    for(int i = 0; i < nums.Length; i++)
    {
        if (hash.ContainsKey(nums[i]))
        {
            int count = hash[nums[i]] + 1;
            hash.Remove(nums[i]);
            hash.Add(nums[i], count);
            continue;
        }
        hash.Add(nums[i], 1);
    }
    foreach(var key in hash.Keys)
    {
        if (hash[key] <=times)
        {
            continue;
        }
        result.Add(key);
    }
    return result;
}
Console.WriteLine("Hello, World!");
