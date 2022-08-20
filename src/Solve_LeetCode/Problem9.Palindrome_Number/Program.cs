bool IsPalindrome(int x) 
{
    string number = x.ToString();
    int len = number.Length;
    int middle = 0;
    middle = len / 2;
    int left = middle - 1;
    int right = len % 2 == 0 ? middle : middle + 1;
  
    while (left<right && left>-1)
    {
        if (number[left] == number[right])
        {
            left--;
            right++;
        }
        else
        {
            return false;

        }

    }

    return true ;
}
Console.WriteLine(IsPalindrome(-121));
