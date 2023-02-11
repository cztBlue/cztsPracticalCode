using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class Valid_Parentheses
    {
        public static void Main(string[] args) 
        {
            Valid_Parentheses ans = new Valid_Parentheses();
            System.Console.WriteLine(ans.IsValid("(){}}{"));
        }
        public bool IsValid(string s)
        {
            //Convert.ToInt32(AC.Peek())
            Stack AC = new Stack();
            int StackTop = -1; 
            if (s.Length == 1) return false;

            for (int i = 0; i < s.Length; i++)
            {
                StackTop = -1;
                if (AC.Count != 0) StackTop = Convert.ToInt32(AC.Peek());
                AC.Push(s[i]);

                if (StackTop == 40 && s[i] == 41)
                { 
                    AC.Pop();
                    AC.Pop();
                }
                else if (StackTop == 123 && s[i] == 125)
                { 
                    AC.Pop();
                    AC.Pop();
                } 
                else if (StackTop == 91 && s[i] == 93)
                { 
                    AC.Pop();
                    AC.Pop();
                }
            }
            if (AC.Count != 0) return false;
            else
            {
                return true;
            }
        }
    }
}
