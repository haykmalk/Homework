using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_3
{
    class Program
    {
        static void ChangeMatrix(int[,]input)
        {
            if(input.GetLength(0) != input.GetLength(1))
            {
                Console.WriteLine("wrong input");
            }
            for(int i = 0; i < input.GetLength(0);i++)
            {
                for(int j = 0; j < input.GetLength(1);j++)
                {
                    if(i >j)
                    {
                        input[i, j] = 0;
                    }
                }
            }
        }
        static void ShowMatrix(int[,]origin)
        {
            for(int i = 0; i < origin.GetLength(0);i++)
            {
                for(int j = 0; j < origin.GetLength(1);j++)
                {
                    Console.Write(origin[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a =
            {
                { 1,2,3,4},
                { 5,6,7,8},
                { 9,10,11,12},
                {13,14,15,16 }
            };

            ChangeMatrix(a);
            ShowMatrix(a);
        }
    }
}
