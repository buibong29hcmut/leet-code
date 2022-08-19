
string convert(string s, int numRows)
{
    List<string> list = new List<string>(Math.Min(s.Length,numRows));
    int currentRow = 0;
    bool goingdown = false;
    string re = "";
    foreach(char item in s)
    {
        if (list[currentRow] is null)
        {
            list[currentRow] = "";
        }
        list[currentRow] += item.ToString();
        if(currentRow==0 || currentRow == list.Count)
        {
            goingdown = !goingdown;
        }
        currentRow+= goingdown ? 1 : -1;
       
    }
    foreach(var item in list)
    {
        re += item;
    }
    return re;

}
