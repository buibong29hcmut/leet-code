
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
    public int SumNumbers(TreeNode root)
    {
        int result = 0;
        int sum = 0;
        Dfs(root,ref sum,0);
        return sum;
       
    }
    void Dfs(TreeNode root,ref int sum,int curr)
    {
        int val = curr * 10 + root.val;

        if (root.left==null&& root.right == null)
        {
            sum += val;
        }
        if (root.left != null)
        {    
            Dfs(root.left, ref sum, val);
        }
        if (root.right != null)
        {
            Dfs(root.right,ref sum, val);
        }
    }
}
public class Program
{
    public static void Main()
    {
        TreeNode treeNode = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        int result = new Solution().SumNumbers(treeNode);
        Console.WriteLine(result);

    }
}
