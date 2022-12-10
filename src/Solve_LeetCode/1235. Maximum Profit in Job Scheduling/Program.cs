using System.ComponentModel.DataAnnotations;

public class Solution
{
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        int left = 0;
        int right = endTime.Length - 1;
        int mid= (left+right)/2;
        int result = int.MinValue;
      
        
    }
    public int JobSchedulingHelper(int[] startTime, int[] endTime, int[] profit,int left, int right)
    {
        int mid = (left + right) / 2;
        int result = 0;
        result = result + profit[mid];

        while (left>=0|| right< profit.Length)
        {
            left = mid - 1;
            right = mid + 1;
        }
    }
}
