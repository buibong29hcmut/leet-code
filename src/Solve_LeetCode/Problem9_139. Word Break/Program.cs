public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        int start = 0;
        string result = "";
        for(int i = 0; i < s.Length; i++)
        {
            string check = s.Substring(start, i - start+1);
            if (wordDict.Contains(check))
            {
                result += check;
                start = i + 1;
            }
        }
        return result == s;
    }
    
}
public class Program
{
   public static void Main()
    {
        Solution solution = new Solution();
       var result= solution.WordBreak("aaaaaaa", new List<string>() { "aaaa", "aaa" });
        Console.WriteLine(result);
    }
}

