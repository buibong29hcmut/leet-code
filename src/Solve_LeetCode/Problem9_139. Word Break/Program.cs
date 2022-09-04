public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        return WordBreadEx(s, wordDict, 0);
    }
    public bool WordBreadEx(string s, IList<string> worDict,int end)
    {   if (end>= s.Length)
            return true;
        if (s.Length == 1)
            return worDict.Contains(s);
        for(int i = end+1 ; i < s.Length; i++)
        {
            if(worDict.Contains(s.Substring(end,i-end+1))&& WordBreadEx(s, worDict, i+1))
            {
                return true;
            }
        }
        return false;
    }
    
}
public class Program
{
   public static void Main()
    {
        Solution solution = new Solution();
       var result= solution.WordBreak("ababcode", new List<string>() { "a","b","code" });
        Console.WriteLine(result);
    }
}

