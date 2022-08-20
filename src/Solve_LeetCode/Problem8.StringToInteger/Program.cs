int myAtoi(string input)
{
    int result = 0;
    int sign = 1;
    int index = 0;
    while (input[index]==' ')
    {
        index++;
    }
    if (input[index] == '-')
    {
        sign = -sign;
        index++;
    }
    if(input[index] == '+')
    {
        index++;
    }
    while (index<input.Length &&input[index]!=null && char.IsDigit(input[index]))
    {
        int re = input[index] - '0';
        result = result * 10 + re;
        index++;
    }

    return result * sign;
}


Console.WriteLine(myAtoi(" -321"));
