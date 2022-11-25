public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int max = 0;
        for(int i=0;i<s.Length;i++)
        {
            bool stop = false;
            int count = 0;
            int moveNext = i;
            Stack<char> stack= new Stack<char>();
            while (stop==false&& moveNext<s.Length)
            {
                if (s[moveNext] == ')' && stack.Count == 0)
                    stop = true;
                if (s[moveNext]=='('&& moveNext!=s.Length-1)
                    stack.Push(s[moveNext]);
                if (s[moveNext]==')'&& stack.Count>0&& stack.Peek()=='(')
                {
                    stack.Pop();
                    count += 2;
                }
           
                moveNext++;
            }
            if(stack.Count>0)
            {
                count = 0;
            }
            max=Math.Max(max, count); 
        }
        return max;
    }
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.LongestValidParentheses("(())("));
    }
}