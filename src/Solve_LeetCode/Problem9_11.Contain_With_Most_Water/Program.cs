int MaxArea(int[] height)
{
    int result = 0;
    int left = 0;
    int right = height.Length - 1;
    while (left < right)
    {
        result = Math.Max(result, (right-left)*Math.Min(height[left], height[right]));
        if (height[left] <=height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return result;
}
Console.WriteLine(MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
