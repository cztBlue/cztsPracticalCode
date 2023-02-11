using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class Trap_YS
    {
        public static void Main(string[] args) 
        {
            Trap_YS trap_YS = new Trap_YS();
            int[] a = { 4, 2, 0, 3, 2, 5 };
            System.Console.WriteLine(trap_YS.Trap(a));
        }
        public int Trap(int[] height)
        {
            //int ans = 0;
            //Stack<int> stack = new Stack<int>();
            //int len = height.Length;

            //for (int i = 0; i < len; ++i)
            //{
            //    while (stack.Count != 0 && height[i] > height[stack.Peek()])
            //    {
            //        int top = stack.Pop();
            //        if (stack.Count == 0)
            //            break;
            //        int left = stack.Peek();
            //        int currWidth = i - left - 1;
            //        int currHeight = Math.Min(height[left], height[i]) - height[top];
            //        ans += currWidth * currHeight;
            //    }
            //    stack.Push(i);
            //}
            //return ans;

            Stack<int> Ac = new Stack<int>();
            int W = 0, H = 0;
            int Position = -1, Data = -1;
            int Top = 0, Position_T = 0;
            int ans = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (Ac.Count != 0)
                {
                    Position = (int)Ac.Pop();
                    Data = (int)Ac.Peek();
                    Ac.Push(Position);
                }

                while (Ac.Count != 0 && Data < height[i])
                {
                    //弹出栈顶
                    Ac.Pop();
                    Top = Ac.Pop();

                    if (Ac.Count == 0) break;

                    Position = Ac.Pop();
                    Data = Ac.Peek();
                    Ac.Push(Position);

                    W = i - Position - 1;
                    H = Math.Min(Data, height[i]) - Top;
                    
                    ans += W * H;
                }
                Ac.Push(height[i]);
                Ac.Push(i);

                if (Data > height[i] || Ac.Count == 0)
                {
                    Ac.Push(height[i]);
                    Ac.Push(i);
                }
            }
            return ans;
        }
    }
}
