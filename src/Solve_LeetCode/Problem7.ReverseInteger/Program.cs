int Reverse(int x)
{
    int result = 0;
    int sign = 1;
    if (x < 0)
    {
        x = Math.Abs(x);
        sign = -sign;
    }
    while (x > 0)
    {
       int  sodu = x % 10;
        x = x / 10;
        if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && sodu > 7)) return 0;
        result = result * 10 + sodu;
     
    

    }
    return result*sign;
}
Console.WriteLine(Reverse(-2147483648));
