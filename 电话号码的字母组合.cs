using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    internal class Telephone
    {
        string[] two = { "a", "b", "c" };
        string[] three = { "d", "e", "f" };
        string[] four = { "g", "h", "i" };
        string[] five = { "j", "k", "l" };
        string[] six = { "m", "n", "o" };
        string[] seven = { "p", "q", "s", "r" };
        string[] eight = { "t", "u", "v" };
        string[] nine = { "w", "x", "y", "z" };
        public static void Main(string[] args)
        {
            Telephone s = new Telephone();
            Console.WriteLine(s.LetterCombinations("23"));
        }

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> ans = new List<string>();
            IList<string> temp = new List<string>();
            int len = digits.Length;
            

            if (len == 0)
                return ans;

            temp = LetterCombinations(digits.Substring(1, len - 1));
            int len_t = temp.Count;

            string[] cur = new string[4];

            switch (digits[0])
            {
                case '2':
                    cur = two;
                    break;
                case '3':
                    cur = three;
                    break;
                case '4':
                    cur = four;
                    break;
                case '5':
                    cur = five;
                    break;
                case '6':
                    cur = six;
                    break;
                case '7':
                    cur = seven;
                    break;
                case '8':
                    cur = eight;
                    break;
                case '9':
                    cur = nine;
                    break;
            }

            if (len == 1)
                return cur;

            for (int i = 0; i < len_t; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ans.Add(cur[j] + temp[i]);
                }
            }
            return ans;
        }
    }
}
