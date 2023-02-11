using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class Different_Tree
    {
        public static void Main(string[] args)
        {
            Different_Tree different_Tree = new Different_Tree();
            System.Console.WriteLine(different_Tree.GeTrees(1,2));
        }

        public int NumTrees(int n)
        {
            int ans = 0;
            if (n == 0 || n == 1) return 1;
            for (int i = 1; i < n + 1; i++)
            {
                ans += NumTrees(i - 1) * NumTrees(n - i);
            }
            return ans;
        }

        public IList<TreeNode> GeTrees(int a, int b)
        {
            IList<TreeNode> ans = new List<TreeNode>();
            if (a > b) 
            {
                ans.Add(null);
                return ans;
            }
            //List<int> Result = listA.Union(listB).ToList<int>();
            for (int i = a; i <= b; i++)
            {
                IList<TreeNode> Left = new List<TreeNode>();
                IList<TreeNode> Right = new List<TreeNode>();

                Left = GeTrees(a, i - 1);
                Right = GeTrees(i + 1, b);

                foreach (TreeNode left in Left)
                {
                    foreach (TreeNode right in Right)
                    {
                        TreeNode t = new TreeNode(i);
                        t.right = right;
                        t.left = left;
                        ans.Add(t);
                    }
                }
            }
            return ans;
        }
//for (int i = a; i<b + 1; i++)
//            {
                
//                foreach (TreeNode s in GeTrees(a, i - 1))
//                {
//                    TreeNode t = new TreeNode(i);
//        t.left = s;
//                    foreach (TreeNode temp in GeTrees(i + 1, b))
//                    {
//                        t.right = temp;
//                        ans.Add(t);
//                    }
//}
//            }

    }
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
}
