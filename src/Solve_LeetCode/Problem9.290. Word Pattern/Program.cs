bool WordPattern(string pattern, string s)
{
    Dictionary<char, string> hashPattern = new();
    string[] arr = s.Split(' ');
    if(pattern.Length != arr.Length)    
        return false;
    for(int i = 0; i < pattern.Length; i++)
    {
        if (hashPattern.ContainsKey(pattern[i]))
        {
            if (hashPattern[pattern[i]] != arr[i])
                return false;
        }
        if (hashPattern.ContainsValue(arr[i]))
        {
            return false;
        }
        hashPattern.Add(pattern[i], s);
    }
    return true;
}
Console.WriteLine("Hello, World!");
