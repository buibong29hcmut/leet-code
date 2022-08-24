public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> result = new List<string>();
        GenerateIpAddresses(s, "", result, 0, 0);
        return result;
    }
    private void GenerateIpAddresses(string s, string item ,List<string> result, int index, int count = 0)
    {  if (count > 4)
            return;
        if (index==s.Length&& count == 4)
            result.Add(item);
        else if(count<4)
        {
            for (int i = index + 1; i <= index + 3 && i < s.Length; i++)
            {
                string temp = s.Substring(index, i - index-1);
                int curr = 0;
                if (string.IsNullOrEmpty(temp))
                    curr = 0;
                else { curr = Convert.ToInt32(temp); }
                if (temp[0] == '0' && temp.Length != 1)
                    return;

                if (curr >= 0 && curr <= 255)
                {
                    GenerateIpAddresses(s, item + (item.Length == 0 ? "" : '.') + curr, result, i, count + 1); ;
                }
            }
        }
    }
    
}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.RestoreIpAddresses("25525511135").ToList();
        result.ForEach(p => Console.WriteLine(p));

    }
}
