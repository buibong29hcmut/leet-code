bool IsAnagram(string s, string t)
{
    char[] schar = s.ToCharArray();
    char[] tchar = s.ToCharArray();
    Array.Sort(schar);
    Array.Sort(tchar);
    return new string(schar) == new string(tchar);
}
Console.WriteLine("Hello, World!");
