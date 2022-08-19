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
    }

    return result;
}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
