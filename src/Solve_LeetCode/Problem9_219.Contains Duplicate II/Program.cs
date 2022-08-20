 bool ContainsNearbyDuplicate(int[] nums, int k)
{ bool result=false;
    Dictionary<int, int> hash = new();
    for(int i = 0; i < nums.Length; i++)
    {
        if (hash.ContainsKey(nums[i]))
        {
            result = Math.Abs(hash[nums[i]] - i) < k;
            if (result == true)
            {
                return result;
            }
            hash.Remove(nums[i]);
        }
        hash.Add(nums[i], i);
        
    }
    return result;

}
Console.WriteLine("Hello, World!");
