public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
            return;
        int index = 0;
        for(int i = m; i < nums1.Length; i++)
        {
            nums1[i] = index++;
        }
        Array.Sort(nums1);
    }
}
