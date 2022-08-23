
public class Solution
{

    public IList<string> LetterCombinations(string digits)
    {
        string[] tables
            = { "0", "1", "abc", "def", "ghi",
            "jkl", "mno", "pqrs", "tuv", "wxyz" };
            
        IList<string> result= new List<string>();
     
            GenerateLetterCombination(result, new char[digits.Length], digits, tables, 0);
        return result;
    }
    public void GenerateLetterCombination(IList<string> result, char[] saveString,string digits, string[]tables,int indexDigit)
    {
        if (String.IsNullOrEmpty(digits))
            return ;
        if (indexDigit == digits.Length)
            result.Add(new string(saveString));
        else
        {
            int indextable = digits[indexDigit] - '0';
            for (int i = 0; i < tables[indextable].Length; i++)
            {
                saveString[indexDigit] = tables[indextable][i];
                GenerateLetterCombination(result, saveString,digits, tables,indexDigit+1);
            }
        }
    }
}
