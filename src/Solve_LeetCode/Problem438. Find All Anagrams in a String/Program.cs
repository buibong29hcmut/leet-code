using System.ComponentModel;
using System.Linq;

public class Solution
{
   
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> res = new List<int>();
        if (s.Length < p.Length) return res;
        int[] map = new int[128];
        foreach (char c in p.ToCharArray())
        {
            map[c]++;
        }
        int left = 0, right = 0;
        char[] chars = s.ToCharArray();
        int m = s.Length, n = p.Length, count = n;
        while (right < m)
        {
            if (map[chars[right++]]-- > 0) count--;
            if (count == 0) res.Add(left);
            if (right - left == n && map[chars[left++]]++ >= 0) count++;
        }
        return res;
    }
}
public class PRogram
{
    public static void Main()
    {
        int[] a = new int[2];
        int i = 0;
        if (a[i++]--== 0)
        {
            Console.WriteLine("b");
        }
        if (a[i++]++ == 0)
        {
            Console.WriteLine("c");
        }
        Console.WriteLine(i);
        var result = new Solution().FindAnagrams("cbaebabacd", "abc");
        result.ToList().ForEach(p => Console.WriteLine(p));
    }
}
          