using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.GoogeRA.Sprint4.TaskReview.V17.Lib
{
    public class DataService 
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int SumMtrx = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((mtrx[i, j] % 2) == 0)
                    {
                        SumMtrx++;
                    }
                }

            }
            return SumMtrx;
        }
    }
}
