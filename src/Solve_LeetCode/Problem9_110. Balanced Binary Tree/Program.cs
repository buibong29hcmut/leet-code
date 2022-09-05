
  public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
       this.val = val;
        this.left = left;
        this.right = right;
     }
  }
 
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;
        int leftDept = GetDept(root.left);
        int rightDept = GetDept(root.right);
        if (Math.Abs(leftDept - rightDept) > 1)
            return false;
        return IsBalanced(root.left)&& IsBalanced(root.right);

    }
    public int GetDept(TreeNode root)
    {
        if (root == null)
            return 0;
        return Math.Max(GetDept(root.left), GetDept(root.right)) + 1;
    }
}
