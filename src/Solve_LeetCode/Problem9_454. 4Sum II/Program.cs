
public class Solution
{   
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        Dictionary<int, int> check = new Dictionary<int, int>();
        for(int i = 0; i < nums3.Length; i++)
        {
            for(int j = 0; j < nums4.Length; j++)
            {   int sum = nums3[i] + nums4[j];
                if (check.ContainsKey(sum))
                {
                    int countSum = check[sum];
                    check[sum] = countSum+1;
                    continue;
                }
                check.Add(sum, 1);
                
            }
        }
        int result = 0;
        for(int i = 0; i < nums2.Length; i++)
        {
            int countsum = 0;
            for (int j = 0; j < nums1.Length; j++)
            {  
               if(check.TryGetValue(-1*(nums1[j] + nums2[i]), out countsum))
                {
                    result += countsum;

                };
            }
        }
        return result;

    }
}
