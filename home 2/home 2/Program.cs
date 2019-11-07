using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_2
{
    class Program
    {
        static void Delete(int[]origin,int pos)
        {
            int[] final = new int[origin.Length - 1];
            for(int i = 0; i<pos;i++)
            {
                final[i] = origin[i];
            }
            int j = pos;
            for (int i =pos+1;i <origin.Length;i++ )
            {
               
                final[j] = origin[i];
                j++;
            }
            for(int i = 0;i < final.Length;i++)
            {
                Console.Write(final[i] + ",");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 7, 8,9,10,11 };
            Delete(a, 3);
        }
    }
}
