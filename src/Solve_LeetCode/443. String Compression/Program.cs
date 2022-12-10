public class Solution
{
    public int Compress(char[] chars)
    {
        int indexChar = 0;
        int curr = 0;
        string compress = "";
        while(indexChar<chars.Length)
        {
        
            compress += chars[indexChar];
            int countChar = 1;
            chars[curr++] = chars[indexChar];
            while (indexChar+1<=chars.Length-1 && chars[indexChar + 1] == chars[indexChar])
            {
                indexChar++;
                countChar++;
            }
            indexChar++;
            if (countChar == 1)
                continue;
            foreach(var c in countChar.ToString())
            {
                chars[curr++] = c;
            }
            compress += countChar;
        }
        return compress.Length;
    }
}
