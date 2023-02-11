using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class LargestRectangle
    {
        public static void Main() 
        {
            var obj = new LargestRectangle();
            int[] height = { 1, 1 };
            Console.WriteLine(obj.LargestRectangleArea(height));
        }
        public int LargestRectangleArea(int[] heights)
        {
            int len = heights.Length;
            int[] order = (int[])heights.Clone();
            int max = 0, ans = order[len - 1];
            int area = 0, i = 0;
            int wide = 0;

            Array.Sort(order);

            for (int height = 0; i < len; i++)
            {
                if (order[i]==height)
                    continue;
                height = order[i];
                for (int j = 0; j < len; j++)//找到当前高度的最大矩形
                {
                    if (heights[j] >= height)
                    {
                        wide++;
                        continue;
                    }    
                    else
                    {
                        area = wide * height;
                        wide = 0;
                        if (area > max)
                            max = area;
                    }
                }

                area = wide * height;
                wide = 0;
                if (area > max)
                    max = area;

                if (max > ans)
                    ans = max;
            }

            return ans;
        }
    }
}
