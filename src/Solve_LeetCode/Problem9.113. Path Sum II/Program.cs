
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
    public IList<IList<int>> PathSum(TreeNode root ,int targetSum)
    {
        List<IList<int>> list = new List<IList<int>>();
        Dfs(root, 0, targetSum, list, new List<int>());
        return list;
    }
    public void Dfs(TreeNode root,int current,int targetSum,List<IList<int>> result,List<int> item)
    {   if (root == null)
            return;
        current += root.val;
        item.Add(root.val);
        if (root.left == null&& root.right == null)
        {
            if (current == targetSum)
            {
                result.Add(item);
            }
            else
            {
                return;
            }
        }
        if (root.left != null)
        {
            Dfs(root.left, current, targetSum, result, new List<int>(item));
        }
        if (root.right != null)
        {
            Dfs(root.right, current, targetSum, result, new List<int>(item));
        }
    }
}
