
  public class TreeNode
{
      public int val;
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
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        if (root.right != null)
        {
            if (root.right.val <= root.val)
            {
                return false;
            }
        }


            if (root.left != null)
            {
                if (root.left.val >= root.val)
                {

                    return false;
                }

            }
            if (!IsValidBST(root.left) || !IsValidBST(root.right))
            {
                return false;
            }
        

            return true;
        }


    }


