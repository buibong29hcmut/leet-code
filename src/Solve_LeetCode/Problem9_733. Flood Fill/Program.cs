public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int oldcolor = image[sr][sc];
        if (color != oldcolor)
            Dfs(image, sr, sc, oldcolor, color);
        return image;
    }
    public void Dfs(int[][] image, int row, int col, int oldcolor, int color)
    {
        if (image[row][col] == oldcolor)
        {
            image[row][col] = color;
            if (row + 1 < image.Length)
            {
                Dfs(image, row + 1, col, oldcolor, color);
            }
            if (col + 1 < image[0].Length)
            {
                Dfs(image, row, col + 1, oldcolor, color);
            }
            if (col - 1 > -1)
            {
                Dfs(image, row, col - 1, oldcolor, color);
            }
            if (row - 1 > -1)
            {
                Dfs(image, row - 1, col, oldcolor, color);
            }
        }
    }
}