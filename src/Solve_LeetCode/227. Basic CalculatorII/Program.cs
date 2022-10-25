public class Solution
{
    public int Calculate(string s)
    {
        int result = 0;
        Stack<int> stack = new Stack<int>();
        char operation = '+';
        int currentNumber = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
                currentNumber = currentNumber * 10 + s[i] - '0';
            if ((!char.IsDigit(s[i])&& !char.IsWhiteSpace(s[i]))|| (i == s.Length - 1))
            {
                if(operation == '+')
                {
                    stack.Push(currentNumber);
                }
                else if (operation == '-')
                {
                    stack.Push(-currentNumber);
                }
                else if (operation == '/')
                {
                    stack.Push(stack.Pop() /currentNumber);

                }
                else if(operation=='*')
                {
                    stack.Push(stack.Pop() * currentNumber);

                }
                operation = s[i];
                currentNumber = 0;
            }
     
                
        }
        while (stack.Count()>0)
        {
            result += stack.Pop();
        }
        return result;
    }
}