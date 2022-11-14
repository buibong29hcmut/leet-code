public class Solution
{
    public string DecodeString(string s)
    {
        int count = 0;
        Stack<int> stackNums= new Stack<int>();
        Stack<char> stackChar= new Stack<char>();
        for(int i=0;i<s.Length;i++)
        {
            if (s[i]>='0'&& s[i]<='9')
            {
                count = count * 10 + s[i] - '0';
            }
            else if (s[i]==']')
            {
                int repeat = stackNums.Pop();
                string temp = "";
                while (stackChar.Peek() != '[')
                {
                    temp = stackChar.Pop()+temp;
                }
                stackChar.Pop();
                for(int loop=0; loop < repeat; loop++)
                {
                    for(int j = 0; j < temp.Length; j++)
                    {
                        stackChar.Push(temp[j]);
                    }
                }
            }
            else
            {
                if (count != 0)
                {
                    stackNums.Push(count);  
                }
                count = 0;
                stackChar.Push(s[i]);
            }
        }
        string result = "";
        while (stackChar.Count>0)
        {
            result = stackChar.Pop() + result;
        }
        return result;
    }
}