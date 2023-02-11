using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class median
    {
        public static void Main(string[] arg)
        {
            int[] a = { 1,3};
            int[] b = { 2 };
            Solution solution = new Solution();
            double result = solution.FindMedianSortedArrays(a,b);
            System.Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int Aptr = 0, Bptr = 0, i, len = nums1.Length + nums2.Length;
            int[] ans = new int[len];
            double Ans = 0;

            for (i = 0; i < (len); i++)
            {
                if (Aptr == nums1.Length )
                {
                    ans[i] = nums2[Bptr];
                    Bptr++;
                    continue;
                }
                else if (Bptr == nums2.Length )
                {
                    ans[i] = nums1[Aptr];
                    Aptr++;
                    continue;
                }

                if (nums1[Aptr] > nums2[Bptr])
                {
                    ans[i] = nums2[Bptr];
                    Bptr++;
                }
                else if (nums1[Aptr] < nums2[Bptr])
                {
                    ans[i] = nums1[Aptr];
                    Aptr++;
                }
                else
                {
                    ans[i] = nums1[Aptr];
                    ans[++i] = nums2[Bptr];
                    Aptr++;
                    Bptr++;
                }
            }
            if (len % 2 == 0)
            {
                Ans = (double)ans[(len) / 2 - 1] + ans[(len) / 2];
            }
            else
            {
                Ans = (double)ans[(len) / 2];
            }

            return Ans;
        }
    }

}
