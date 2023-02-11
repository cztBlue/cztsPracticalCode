using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class fjvd
    {
        public static void Main(string[] args)
        {
            fjvd fjvd = new fjvd();
            System.Console.WriteLine(fjvd.Reverse(-123));
        }
        public int Reverse(int x)
        {
            //标答1
        //    long n = 0;
        //    while (x != 0)
        //    {
        //        n = n * 10 + x % 10;
        //        x = x / 10;
        //    }
        //    return (int)n == n ? (int)n : 0;
        //}
        int[] m = new int[10];
            int i, j;
            long res = 0;
            int flag = 1;

            if (x < 0)
            {
                res = -(x + 1);
                res++;
                flag = -1;
            }
            else
            { res = x; }
            for (i = 0; i < 10; i++)
            {
                m[i] = (int)(res % 10);
                res /= 10;
                if (res == 0) break;
            }
            //if(超过) return 0;
            res = 0;
            int temp = i;
            for (j = 0; j <= temp; j++)
            {
                res += m[j] * (long)Math.Pow(10, i--);
            }
            if (res > 2147483647 || res * flag < -2147483648) return 0;
            return (int)res * flag;
        }
    }
}
