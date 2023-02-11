using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Sum
    {
        public static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            int i;
            for (i = 0; i < 3; i++)
            {
                l1.val = i;
                l1 = l1.next;
            }
            Solution s = new Solution();
            System.Console.WriteLine(s.AddTwoNumbers(l1, l1));
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                int size1, size2, Size1, Size2;
                int ansnum1 = 0, ansnum2 = 0;
                int[] arr1 = new int[101];
                int[] arr2 = new int[101];


                ListNode head1 = new ListNode();
                ListNode head2 = new ListNode();
                ListNode Ans = new ListNode();
                ListNode ans = Ans;

                head1 = l1;
                head2 = l2;

                int i, j;
                for (size1 = 0; l1 != null; l1 = l1.next)
                {
                    size1++;
                }

                for (size2 = 0; l2 != null; l2 = l2.next)
                {
                    size2++;
                }

                Size1 = size1;
                Size2 = size2;

                for (i = 0; i < Size1; i++)
                {
                    l1 = head1;
                    for (j = size1; j > 1; j--)
                    {
                        l1 = l1.next;
                    }
                    arr1[i] = l1.val;
                }

                for (i = 0; i < Size2; i++)
                {
                    l2 = head2;
                    for (j = size2; j > 1; j--)
                    {
                        l2 = l2.next;
                    }
                    //ansnum2 += l2.val*(int)Math.Pow(10, --size2);
                    arr2[i] = l1.val;
                }

                //头插建表
                int digits;
                for ()
                {
                    digits = 0;
                    ListNode s = new ListNode();
                    Ans.next = s;
                    for (i = Size1, j = Size2; i > 0 || j > 0;)
                    {
                        //digits= 0;
                        if (i > 0 && j > 0)
                        {
                            if (arr1[i] + arr2[j] > 9)
                            {
                                s.val = arr1[i] + arr2[j] - 10 + digits;
                                digits = 1;
                            }
                            else
                            {
                                s.val = arr1[i] + arr2[j] + digits
                            }
                            j--,i--;
                        }
                        else if (i > 0 && j < 0)
                        {
                            arr1[i];
                            i--;
                        }
                        else if (i < 0 && j > 0)
                        {
                            arr2[j];
                            j--;
                        }
                    }
                    Ans = s;
                }

                return ans;
            }
        }
    }

}

