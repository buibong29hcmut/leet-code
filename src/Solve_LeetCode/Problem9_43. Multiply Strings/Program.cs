using System.Text;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        StringBuilder result = new StringBuilder();
        int index = -1;
        List<StringBuilder> storeItem = new List<StringBuilder>();
        if (num1 == "0" || num2 == "0")
            return "0";
       for(int j=num1.Length-1; j>-1; j--)
        {   index++;
            int number1 = num1[j] - '0';
            string Item = "";
            int carry = 0;
            for(int i=num2.Length-1; i>-1; i--)
            {
                int number2 = num2[i] - '0';
                Item= Item+((number1*number2+carry)%10).ToString();

                carry = (number1 * number2+carry) / 10;
            }
            if (carry >= 1)
                Item += carry.ToString();
            StringBuilder builder = new StringBuilder(new string(Item.Reverse().ToArray()));
            for(int i = 0; i <index; i++)
            {
                builder.Append('0');
            }
            storeItem.Add(builder);
        }
        int indexitem = storeItem[storeItem.Count-1].Length;
        int minusIndex = 0;
        int carry2= 0;
        for (int j = indexitem - 1; j > -1; j--)
        {
            int sum = 0;
            minusIndex++;      
            for (int i = storeItem.Count - 1; i > -1; i--)
            {
                int indexchar = storeItem[i].Length - minusIndex;
                if (indexchar < 0)
                    continue;
                sum = sum + storeItem[i][indexchar] - '0' ;


            }
            sum = sum + carry2;
            carry2 = sum / 10;
            result.Append(sum % 10);
        }
        if (carry2 > 0)
        {
            result.Append(carry2);
        }
        return new string(result.ToString().Reverse().ToArray());
    }
}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.Multiply("123456789", "987654321"));
       
    }
}