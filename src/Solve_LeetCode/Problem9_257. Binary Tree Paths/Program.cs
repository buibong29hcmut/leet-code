
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
    public IList<string> BinaryTreePaths(TreeNode root)
    {   List<string> result = new List<string>();
        Dfs(root, result);
        return result;
    }
    public void Dfs(TreeNode root,List<string> result,string item="")
    {
       if(root==null)
        {
            result.Add(item);
            return;
        }
        item = item + root.val;
        if (root.left != null)
        {
            Dfs(root.left, result, item + "->");
        }
        if (root.right != null)
        {
            Dfs(root.right, result, item + "->");
        }
    }
}
public class Program
{
    public static void Main()
    {
        var result = new Solution().BinaryTreePaths(new TreeNode(1, new TreeNode(3), new TreeNode(5)));
        result.ToList().ForEach(p => Console.WriteLine(p));
    }
}
