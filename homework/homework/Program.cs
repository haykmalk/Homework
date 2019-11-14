using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrix myMatrix1 = new Matrix(3, 4, 3, 4, "Add");
            //myMatrix1.ShowMatrixInput1();
            //Console.WriteLine();
            //myMatrix1.ShowMatrixInput2();
            //myMatrix1.Add();
            //Console.WriteLine();
            //myMatrix1.ShowMatrixOutput();
            ///////////////////////////
            Matrix myMatrix2 = new Matrix(3, 4, 4, 3, "Multiply");
            myMatrix2.ShowMatrixInput1();
            Console.WriteLine();
            myMatrix2.ShowMatrixInput2();
            myMatrix2.Multiply();
            Console.WriteLine();
            myMatrix2.ShowMatrixOutput();


        }
    }
}
