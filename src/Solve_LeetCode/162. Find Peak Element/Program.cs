public class Solution
{
    public int FindPeakElement(int[] nums)
    {
       
        return FindElementHelper(nums, 0, nums.Length-1);


    }
    public int FindElementHelper(int[] nums,int left, int right)
    {
        if (nums.Length == 1)
            return 0;
        while (left <=right)
        {   
            
            int mid = (left + right) / 2;
            if(mid==0)
            {
                return nums[mid] > nums[mid + 1] ? mid : FindElementHelper(nums,mid+1,right);
            }
            if (mid == nums.Length-1)
            {
                return nums[mid] > nums[mid -1] ? mid : FindElementHelper(nums,left,mid-1);
            }
            if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
            {
                return mid;
            }
            int result1= FindElementHelper(nums, left, mid-1);
            int result2= FindElementHelper(nums,mid+1,right);
            if(result1!=-1)
                return result1;
            if (result2 != -1)
                return result2;
            return -1;

        }
        return -1;
    }
   
}
