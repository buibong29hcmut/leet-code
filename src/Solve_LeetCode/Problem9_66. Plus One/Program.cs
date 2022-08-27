public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int[] result = new int[digits.Length + 1];
        result[result.Length - 1] = (digits[digits.Length - 1]+1)%10;
        if (digits.Length == 0)
            return new[] {1} ;
        int carry = (digits[digits.Length - 1] + 1) / 10;
        for (int i = digits.Length - 2; i >= 0; i--)
        {
            result[i+1] = (digits[i]+carry)% 10;
            carry = (digits[i] + carry) / 10;
        }
        if (carry > 0)
            result[0] = 1;
        else
        {
            int[]newresult = new int[digits.Length];
            for(int i = 0; i < result.Length-1; i++)
            {
                newresult[0] = result[i + 1];
            }
            return newresult;
        }
        return result;
    }
}
