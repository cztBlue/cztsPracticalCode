using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class MainWindow
    {
        public static void Main() 
        {
            MainWindow mainWindow = new MainWindow();
            
        }
        public string MinWindow(string s, string t)
        {
            int len_t = t.Length;
            int len_s = s.Length;

            IDictionary<char, int> dic = new Dictionary<char, int>();
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < len_t; i++)
            {
                if (dic.ContainsKey(t[i]) == false)
                    dic.Add(t[i], 1);
                else
                    dic[t[i]] += 1;
            }

            for (int j = len_s - 1; j >= 0 ; j--)
            {
                if (dic.ContainsKey(s[j]) == true)
                    st.Push(j);
            }

            int minsize = len_s +1;
            int size;
            string ans = "";
            //int end,res_end = len_s-1;

            while (st.Count > 0)
            {
                var arr = new int[st.Count];
                st.CopyTo(arr, 0);
                Array.Reverse(arr);
                Stack<int> st_copy = new Stack<int>(arr);

                var dic_copy = dic.ToDictionary(entry => entry.Key,
                                               entry => entry.Value);

                int end = LenOfStr(s, dic_copy, st_copy);
                int cur = st.Pop();
                size = end - cur + 1;

                if (end == -1)
                    break;

                if (size < minsize)
                {
                    minsize = size;
                    ans = s.Substring(cur, minsize);
                }

            }
            return ans;

        }

        int LenOfStr(string s, IDictionary<char, int> dic, Stack<int> st)
        {
            while (dic.Count > 0 && st.Count > 0)
            {
                int cur = st.Pop();
                if (dic.ContainsKey(s[cur]) == false)
                    continue;
                if (dic[s[cur]] > 0)
                    dic[s[cur]] += -1;

                if (dic[s[cur]] == 0)
                    dic.Remove(s[cur]);

                if (dic.Count == 0)
                    return cur;
            }
            return -1;
        }
    }
}
