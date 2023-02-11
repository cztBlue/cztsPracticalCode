using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    class Solution
    {
        public int lengthOfLongestSubstring(String s)
        {
            // 记录字符上一次出现的位置
            int[] last = new int[128];
            for (int i = 0; i < 128; i++)
            {
                last[i] = -1;
            }
            int n = s.Length;

            int res = 0;
            int start = 0; // 窗口开始位置
            for (int i = 0; i < n; i++)
            {
                int index = s[i];
                start = Math.Max(start, last[index] + 1);
                res = Math.Max(res, i - start + 1);
                last[index] = i;
            }

            return res;
        }
    }
    public class cStr
    {

        public static void Main(string[] args)
        {
        Solution s = new Solution();
        
        //int size = LengthOfLongestSubstring("au");
        //System.Console.WriteLine(size);
        System.Console.WriteLine(s.lengthOfLongestSubstring("soas"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int i, j, k, size = 0;
            int[] Size = new int[129];
            if (s.Length == 0) return 0;
            if (s.Length == 1) return 1;
            for (i = 0; i < s.Length; i++)
            {
               
                for (j = i + 1;; j++)
                {
                    size++;
                    if (j > s.Length - 1) break;
                    for (k = i; k < j; k++)
                    {
                        if (s[k] == s[j]) {goto mm;}
                    }
                }
                mm:
                Size[size] = size;
                size = 0;
            }

            for (i = 128; i >= 0; i--)
            {
                if (Size[i] > Size[i - 1])
                {
                    return Size[i];
                }
            }
            return s.Length;
        }
    }

}
