public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length-1;
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
         


        }

        return true;
    }
}
public class Program
{
    public static void Main()
    {
        new Solution().IsPalindrome("A man, a plan, a canal: Panama");
        Console.ReadLine();
    }
}