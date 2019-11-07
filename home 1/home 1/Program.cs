using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_1
{
    class Program
    {
        static void  ChangeType(double[]first)
        {
            int[] last = new int[first.Length];
            for(int i = 0; i <last.Length;i++)
            {
                last[i] = (int)(first[i]);
                Console.Write(last[i] + ",");
            }
            
        }
        static void Main(string[] args)
        {
            double[] a = { 1.2, 5.8, 3.2 };
            ChangeType(a);
            
        }
    }
}
