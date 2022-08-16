 int LengthOfLongestSubstring(string s)
{
    int result = 0;
    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int j = 0, i = 0; j < s.Length; j++)
    {
        if (map.ContainsKey(s[j]))
        {
            i = Math.Min(j, map[s[j]]);
        }
        result = Math.Max(result, j - i + 1);
        map.Add(s[j], j+1);
    }
    return result;
}
var result= LengthOfLongestSubstring("aab");
Console.WriteLine(result);
