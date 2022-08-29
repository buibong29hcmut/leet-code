public class TreeNode
{
    public int val { get; set; }
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }
    public TreeNode SortedArrayToBST(int[]nums, int left,int right)
    {
        if (left > right)
            return null;
        int mid = (right - left) / 2;
        TreeNode node = new TreeNode(mid);
        node.left = SortedArrayToBST(nums, left, mid - 1);
        node.right = SortedArrayToBST(nums, mid + 1, right);
        return node;
    }
}
