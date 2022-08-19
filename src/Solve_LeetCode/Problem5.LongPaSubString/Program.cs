string LongestPalindrome(string s)
{
    int maxlen = -1;
    int start = 0;
    int end = 0;
    for(int i = 0; i < s.Length-1; i++)
    {
        int len1 = ExpandAndAroundCenter(i, i, s);
        int len2 = ExpandAndAroundCenter(i, i + 1, s);
        int len = Math.Max(len1, len2);
        if (len > end - start)
        {
            start = i - (len - 1) / 2;
            end = i + len / 2;
        }

    }
    return s.Substring(start, end);

}

int ExpandAndAroundCenter(int left,int right,string s)
 {
   while(left>0 && right<s.Length && s[left] == s[right])
    {
        left--;
        right++;
    }
    return right - left -1;
}
    Console.WriteLine("Hello, World!");
