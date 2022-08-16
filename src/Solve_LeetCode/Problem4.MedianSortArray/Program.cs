 double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int m = nums1.Length;
    int n = nums2.Length;
    int j = 0;
    int i = 0;
    int m1 = -1, n1 = -1;
    for(int count= 0; count < (m + n) / 2; count++)
    {
        n1 = m1;
        if (i!= m && j != n)
        {
            m1 = nums1[i] > nums2[j] ? nums2[j++] : nums1[j++];

        }
        else if (i < m)
        {
            m1 = nums1[i++];
        }
        else
        {
            n1 = nums2[j++];
        }
        
        if ((m + n) % 2 == 1)
        {
            return m1;
        }
        return Convert.ToDouble((m1 + n1) / 2);
    }

    return 0;
}
Console.WriteLine("Hello, World!");
