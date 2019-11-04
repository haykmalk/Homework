using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Hayk
{
    class Program
    {
        static int Add(int x , int y)
        {
            int sum = x + y;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,4));
        }
    }
}
