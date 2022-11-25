public class Solution
{
    public int ThreeSumMulti(int[] arr, int target)
    {
        int count = 0;
        for(int i=0;i<arr.Length;i++)
        {
            int left = i + 1;
            int right = arr.Length - 1;
            while(left<right)
            {
                 if(arr[i] + arr[left] + arr[right] == target )
                    count=count+1;
                 right=right-1;

            }
        }
        return count;
    }
}

