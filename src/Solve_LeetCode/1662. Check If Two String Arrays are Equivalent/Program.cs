public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string s1 = "";
        string s2 = "";
        for(int i=0; i < word1.Length; i++)
        {
            s1 += word1[i];
        }
        for (int i = 0; i < word2.Length; i++)
        {
            s1 += word1[i];
        }
        return s1 == s2;
    }
}