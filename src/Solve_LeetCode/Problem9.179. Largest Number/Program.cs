using System.Text;

string LargestNumber(int[] nums)
{
     nums=nums.OrderByDescending(p => p.ToString()[0]).ToArray();
    StringBuilder builder = new StringBuilder();
    for(int i=0;i<nums.Length; i++)
    {
        builder.Append(nums[i].ToString());
    }
    return builder.ToString();
}
LargestNumber(new[] {  2,10,11, 3, 4 });
