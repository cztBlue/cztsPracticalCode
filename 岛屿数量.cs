using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_con
{
    public class array 
    {
        
    }
    internal class IslandNum
    {
        public static void Main() 
        {
            IslandNum s = new IslandNum();
            char[][] m = new char[1][];

            m[0] = new char[16] { '1', '1','1', '0', '0', '1', '1', '1', '0', '1', '1', '0', '0', '1', '1', '1' };
            //m[0] = new char[3] { '1', '1', '1' };
            //m[1] = new char[3] { '0', '1', '0' };
            //m[2] = new char[3] { '1', '1', '1' };

            System.Console.WriteLine(s.NumIslands(m));
        }

        public int NumIslands(char[][] grid)
        {
            int row = grid.Length;
            int column = grid[0].Length;
            int ans = 0;
            bool[,] IsVisit = new bool[grid.Length, grid[0].Length];

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        IsVisit[i, j] = false;
            //    }
            //}

            //int i,j;
            Queue<int[]> myQ = new Queue<int[]>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)//找到'岛头'
                {
                    if (IsVisit[i, j] == true) //跳过已遍历
                        continue;
                    if (grid[i][j] == '1')
                    {
                        int[] pos = new int[2] {i,j };
                        myQ.Enqueue(pos);
                        IsVisit[i, j] = true;
                        BFS(ref grid, ref myQ, ref ans, ref IsVisit, ref row, ref column);
                    }
                    else
                    {
                        IsVisit[i, j] = true;
                    }
                }
            }
            return ans;
        }

        public void BFS(ref char[][] grid, ref Queue<int[]> Q
        , ref int ans, ref bool[,] IsVisit, ref int row, ref int column)
        {
            while (Q.Count != 0)
            {
                int[] cur = (int[])Q.Dequeue();
                int curi = cur[0];
                int curj = cur[1];

                if (curi - 1 >= 0
                && grid[curi - 1][curj] == '1'
                && IsVisit[curi - 1, curj] == false)
                {
                    int[] pos = new int[2] { curi - 1, curj };
                    Q.Enqueue(pos);
                    IsVisit[curi - 1, curj] = true;
                }
                else if(curi - 1 >= 0)
                { 
                    IsVisit[curi - 1, curj] = true; 
                }

                if (curj - 1 >= 0
                && grid[curi][curj - 1] == '1'
                && IsVisit[curi, curj - 1] == false)
                {
                    int[] pos = new int[2] { curi, curj - 1 };
                    Q.Enqueue(pos);
                    IsVisit[curi, curj - 1] = true;
                }
                else if(curj - 1 >= 0)
                {
                    IsVisit[curi, curj - 1] = true;
                }

                if (curi + 1 < row
                && grid[curi + 1][curj] == '1'
                && IsVisit[curi + 1, curj] == false)
                {
                    int[] pos = new int[2] { curi + 1, curj };
                    Q.Enqueue(pos);
                    IsVisit[curi + 1, curj] = true;
                }
                else if(curi + 1 < row)
                {
                    IsVisit[curi + 1, curj] = true;
                }

                if (curj + 1 < column
                && grid[curi][curj + 1] == '1'
                && IsVisit[curi, curj + 1] == false)
                {
                    int[] pos = new int[2] { curi, curj + 1 };
                    Q.Enqueue(pos);
                    IsVisit[curi, curj + 1] = true;
                }
                else if(curj + 1 < column)
                {
                    IsVisit[curi, curj + 1] = true;
                }
            }
            ans++;
        }
    }
}
