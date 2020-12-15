using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace эвм6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] A = new int[n][];
            for (int i = 0; i < n; i++)     
            {
                A[i] = new int[rnd.Next(1,5)];
                for (int j = 0; j < i + 1; j++)
                    A[i][j] = rnd.Next(-1, 5);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < ; j++)
                {
                    Console.Write("{0} ", A[i][j]);
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < n; i++)
            {
                int e = 1;
                int q = 0, w = 0;
                for (int j = 0; j < i+1; j++)
                {
                    if (A[i][j] >= 0)
                    {
                        q++;
                    }
                    w++; 
                }
                if (q == w)
                {
                    for (int t = 0; t < i+1; t++)
                        {
                            e = e * A[i][t];
                        }
                    Console.WriteLine("произведение {1} строки ровно {0}", e, i+1);
                }
            }

            //int Max = A[0][0], y = 0, c=0;
            //int[] Sum = new int[2*n-1];

            //for (int v = 1; v < n; v++)
            //{
            //    y++;
            //    for (int i = v, j; i < n; i++)
            //    {
            //        j = i - y ;
            //        Sum[c] = Sum[c] + A[i][j];
            //    }
            //    for (int i, j = v; j < n; j++)
            //    {
            //        i = j - y;
            //        Sum[1+c] = Sum[1+c] + A[i][j];
            //    }
            //    c = c+2;
            //}

            //for (int i = 0; i < 2*n-1; i++)
            //    if (Sum[i] > Max)
            //        Max = Sum[i];
            //Console.WriteLine("Максимум среди сумм диаганалей, параллельных главной диагонали матрицы равно: {0}", Max);//
        }
    }
}
