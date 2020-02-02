using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class2
    {
        public static int[,] Calc(int[,] matrix, int[,] matrix2, int a, int b)
        {
            int[,] matrixItog;
            matrixItog = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    for (int k = 0; k < b; k++)
                    {
                        matrixItog[i, j] += matrix[i, k] * matrix2[k, j];
                    }
                }
            }
            return matrixItog;
        }
        public static string Print(int [,] matrixItog, int a)
        {
            string[,] arr = new string[a, a];
            string[] mas1 = new string[a + 2];
            mas1[0] = Convert.ToString(a) + "\r\n";
            mas1[1] = Convert.ToString(a) + "\r\n";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = Convert.ToString(matrixItog[i,j]);
                }
            }
            string c = mas1[0] + "\n" + mas1[1] + "\n";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    mas1[i + 2] += arr[i, j] + "\t";   //сохранение из dataGridView в массив

                }
                c = c + mas1[i + 2] + "\r\n";

            }
            return c;
        }
    }
}
