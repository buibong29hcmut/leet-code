bool IsIsomorphic(string s, string t)
{
    if (s.Length != t.Length)
        return false;
    Dictionary<char, char> hash = new Dictionary<char, char>();
    for(int i = 0; i < s.Length; i++)
    {
        if (hash.ContainsKey(s[i]))
        {
            if (hash[s[i]] != t[i])
                return false;

        }
        if (hash.ContainsKey(t[i]))
            return false;
        hash.Add(s[i], t[i]);
      
    }
    return true;
}
Console.WriteLine("Hello, World!");
