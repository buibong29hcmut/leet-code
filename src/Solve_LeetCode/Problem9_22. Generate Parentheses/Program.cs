public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> result= new List<string>();
        GenerateParrensisItem(0, result, new char[2 * n]);
        return result;
    }
    private void GenerateParrensisItem(int index, IList<string> result, char[] current)
    {
        if (index == current.Length)
        {
            if (IsValidParrensis(current))
                result.Add(new string(current));
        }
        else
        {
            current[index] = '(';
            GenerateParrensisItem(index + 1, result, current);
            current[index] = ')';
            GenerateParrensisItem(index + 1, result, current);
        }
    }
    private bool IsValidParrensis(char[] item)
    {
        int balance = 0;
        foreach(var c in item)
        {
            if (c == '(')
                balance++;
            else
                balance--;
            if (balance < 0)
                return false;
        }
        return balance == 0;
    }
}
