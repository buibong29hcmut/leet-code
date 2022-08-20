 int MaxArea(int[] height)
{
    int result = 0;
    for(int i = 0; i < height.Length; i++)
    {
        for(int j = i + i; j < height.Length; j++)
        {
            result = Math.Max(result, (j - i) * Math.Min(height[i], height[j]));
        }
    }
    return result;
}
Console.WriteLine(MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
