 int LengthOfLongestSubstring(string s)
{
    int result = -1;
    for(int i = 0; i < s.Length; i++)
    {
        HashSet<int> hash = new HashSet<int>();
        hash.Add(s[i]);
        int j = i + 1;
        while (j<s.Length&&!hash.Contains(s[j]) )
        {
            hash.Add(s[j]);
            j++;
        }
        result = Math.Max(result, j - i );
    }
    return result;
}
var result= LengthOfLongestSubstring("pwwkew");
Console.WriteLine(result);
