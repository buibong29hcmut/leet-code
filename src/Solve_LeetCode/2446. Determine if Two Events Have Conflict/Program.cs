using System.Diagnostics.CodeAnalysis;

public class Solution
{   
    public int ConvertTime(string[] time)
    {
        return Convert.ToInt32(time[0]) * 60 + Convert.ToInt32(time[1]);
    }
    public bool HaveConflict(string[] event1, string[] event2)
    {
        string[] timeSplit1 = event1[0].Split(':');
        string[] timeSplit2 = event1[1].Split(':');
        string[] timeSplit3 = event2[0].Split(':');
        string[] timeSplit4 = event2[1].Split(':');
        int time1 = ConvertTime(timeSplit1);
        int time2 = ConvertTime(timeSplit2);

        int time3 = ConvertTime(timeSplit3);
        int time4 = ConvertTime(timeSplit4);
        if (time1 <=time3 && time2 >=time3 || time1 > time3 && time4 >=time1)
            return true;
        return false;



    }
}
