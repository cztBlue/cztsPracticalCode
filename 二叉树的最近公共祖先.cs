using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    internal class Public_Ancestor
    {
        public static void Main() 
        {
            Public_Ancestor p = new Public_Ancestor();

            TreeNode root = new TreeNode(3);
            TreeNode C11 = new TreeNode(5);
            TreeNode C12 = new TreeNode(1);
            TreeNode C21 = new TreeNode(6);
            TreeNode C22 = new TreeNode(2);
            TreeNode C23 = new TreeNode(0);
            TreeNode C24 = new TreeNode(8);
            TreeNode C31 = new TreeNode(7);
            TreeNode C32 = new TreeNode(4);

            root.left = C11;
            root.right = C12;
            C11.left = C21; 
            C11.right = C22;
            C12.left = C23;
            C12.right = C24;
            C22.left = C31;
            C22.right = C32;

            C21.left = null;
            C23.left = null;
            C24.left = null;
            C21.right = null;
            C23.right = null;
            C24.right = null;

            System.Console.WriteLine(p.LowestCommonAncestor(root,C32,C11).val);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Dictionary<TreeNode, int> m = new Dictionary<TreeNode, int>();
            DFS(root, p, q, m);

            foreach (TreeNode ans in m.Keys)
            {
                //System.Console.WriteLine(m[ans]);
                if (m[ans] == 2)
                    return ans;
            }

            return root;
        }

        public bool DFS(TreeNode root, TreeNode p, TreeNode q, Dictionary<TreeNode, int> m)
        {
            int flag = 0;

            //当前节点为祖先节点(直接return)不计数的bug未修复
            if (root == p || root == q)
                flag++;
            //return true;

            if (root == null)
                return false;

            m.Add(root, 0);

            if (DFS(root.left, p, q, m) == true )
            {
                flag++;
                m[root] = flag;
            }
            //return true;

            if (DFS(root.right, p, q, m) == true )
            {
                flag++;
                m[root] = flag;
            }
            //return true;

            if (flag > 0)
                return true;
            else
                return false;
        }
    }
}
