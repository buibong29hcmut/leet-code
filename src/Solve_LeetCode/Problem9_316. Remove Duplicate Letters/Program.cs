public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        Stack<char> stack = new Stack<char>();
        bool[] visit = new bool[26];
        int[] res = new int[1000];
        for(int i = 0; i < s.Length; i++)
        {
            res[s[i] - 'a'] += 1;
        }
        foreach(char c in s)
        {
            int index = c - 'a';
            res[index] -= 1;
            if (visit[index]==true)
                continue;
            while (stack.Count() != 0 && c < stack.Peek() && res[stack.Peek() -'a']!=0)
            {
                char pop = stack.Pop();
                visit[pop - 'a'] = false;
            }
            stack.Push(c);
            visit[index] = true;
        }
        return new string(stack.Reverse().ToArray());
    }
}
public class Program
{
    public static void Main()
    {
        var result = new Solution()
                    .RemoveDuplicateLetters("cbacdcbc");
        Console.WriteLine(result);
    }
}
