
     int MajorityElement(int[] nums)
    {
        int times = nums.Length / 2;
        Dictionary<int, int> hash = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.ContainsKey(nums[i]))
            {
                int count = hash[nums[i]] + 1;
                hash[nums[i]] = count;
                if (hash[nums[i]] > times)
                    return nums[i];
                continue;
            }
            hash.Add(nums[i], 1);
            if (hash[nums[i]] > times)
                return nums[i];

        }

        return 0;
    }

Console.WriteLine("Hello, World!");
