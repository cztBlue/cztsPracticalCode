using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class Solution
    {
        public static void Main() 
        {
            Solution s = new Solution();
            System.Console.WriteLine(s.MinimumLength("cabaabac"));
        }
        public int MinimumLength(string s)
        {
            int len = s.Length;
            int hdel = 0, tdel = 0;

            while (hdel < len - tdel-1)
            {
                int i;
                for (i = hdel; i < len - tdel;i++) //全同?
                {
                    if (s[i] !=s[hdel]) break;        
                }
                if (i == len - tdel) return 0;

                if (s[hdel] == s[len - tdel - 1])//比首尾
                {
                    int j;
                    for (; s[hdel + 1] == s[hdel]; hdel++) ;
                    hdel++;
                    for (j = len - tdel - 1; s[j - 1] == s[j]; j--, tdel++) ;
                    tdel++;
                }
                else 
                {
                    break; 
                }
                
            }
            return s.Substring(hdel, len - hdel - tdel).Length;
        }
    }
}
