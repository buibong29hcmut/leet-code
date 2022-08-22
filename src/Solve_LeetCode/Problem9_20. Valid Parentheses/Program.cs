public class Solution
{
    public Dictionary<char, int> Values
    {
        get
        {
            return new Dictionary<char, int>()
                {
                    {'{',3 },
                    {'}',-3 },
                    {'[',2 },
                    {']',-2 },
                    {'(',1 },
                    {')',-1 }
                };
        }
    }

    public bool IsValid(string s)
    {   Stack<char> stack = new Stack<char>();
     
        for(int i = 0; i < s.Length; i++)
        {
            if (Values[s[i]] > 0)
            {
                stack.Push(s[i]);
                continue;
            }
               else if (Values[s[i]] == -1 && stack.Count != 0 && stack.Peek() == '(' )
                {
                    stack.Pop();
                }
                else if (Values[s[i]] == -2 && stack.Count != 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (Values[s[i]] == -3 && stack.Count != 0&&stack.Peek() == '{')
                {
                    stack.Pop();

                }
                else
                    return false;
        }
        return stack.Count==0;
    }
    
    }
public class Program
{
    public static void Main()
    {
        Solution so = new Solution();
        so.IsValid("]");

    }
}