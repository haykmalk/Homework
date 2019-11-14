using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Matrix
    {
        private  int numOfRaws1;
        private int numOfColumns1;
        private int numOfRaws2;
        private int numOfColumns2;
        public string Action { get; set; }
        public  int NumOfRaws1
        {
            get
            {
                return numOfRaws1;
            }
            set
            {
                numOfRaws1 = value; 
            }
        }
        public int NumOfColumns1
        {
            get
            {
                return numOfColumns1;
            }
            set
            {
                numOfColumns1 = value;
            }
        }
        public int NumOfRaws2
        {
            get
            {
                return numOfRaws2;
            }
            set
            {
                numOfRaws2 = value;
            }
        }
        public int NumOfColumns2
        {
            get
            {
                return numOfColumns2;
            }
            set
            {
                numOfColumns2 = value;
            }
        }
        public Matrix(int numOfRaws1, int numOfColumns1, int numOfRaws2, int numOfColumns2, string action)
        {
            this.Action = action;
            this.NumOfRaws1 = numOfRaws1;
            this.NumOfColumns1 = numOfColumns1;
            this.NumOfRaws2 = numOfRaws2;
            this.NumOfColumns2 = numOfColumns2;
            if (Action == "Add")
            {
                matrixInput1 = new int[NumOfRaws1, NumOfColumns1];
                matrixInput2 = new int[NumOfRaws2, NumOfColumns2];
                matrixOutput = new int[NumOfRaws1, NumOfColumns1];


                for (int i = 0; i < matrixInput1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixInput1.GetLength(1); j++)
                    {
                        matrixInput1[i, j] = rd.Next(1, 10);
                    }
                }
                for (int i = 0; i < matrixInput2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixInput2.GetLength(1); j++)
                    {
                        matrixInput2[i, j] = rd.Next(1, 10);
                    }
                }
            }
            if (Action == "Multiply" && matrixInput1.GetLength(1) == matrixInput2.GetLength(0))
            {
                matrixInput1 = new int[NumOfRaws1, NumOfColumns1];
                matrixInput2 = new int[NumOfRaws2, NumOfColumns2];
                matrixOutput = new int[NumOfRaws1, NumOfColumns2];


                for (int i = 0; i < matrixInput1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixInput1.GetLength(1); j++)
                    {
                        matrixInput1[i, j] = rd.Next(1, 10);
                    }
                }
                for (int i = 0; i < matrixInput2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixInput2.GetLength(1); j++)
                    {
                        matrixInput2[i, j] = rd.Next(1, 10);
                    }
                }
            }

        }
        int[,] matrixInput1;
        int[,] matrixInput2;
        int[,] matrixOutput;
        public void ShowMatrixOutput()
        {
            for (int i = 0; i < matrixOutput.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOutput.GetLength(1); j++)
                {
                    Console.Write(matrixOutput[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void ShowMatrixInput1()
        {
            for (int i = 0; i < matrixInput1.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInput1.GetLength(1); j++)
                {
                    Console.Write(matrixInput1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void ShowMatrixInput2()
        {
            for (int i = 0; i < matrixInput2.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInput2.GetLength(1); j++)
                {
                    Console.Write(matrixInput2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Add()
        {
            if(matrixInput1.GetLength(0) == matrixInput2.GetLength(0) && matrixInput1.GetLength(1) == matrixInput2.GetLength(1))
            {
                for (int i = 0; i < matrixInput1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixInput1.GetLength(1); j++)
                    {
                        matrixOutput[i, j] = matrixInput1[i, j] + matrixInput2[i, j];
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong entry");
            }
        }
        public void Multiply()
        {
            
            if (matrixInput1.GetLength(1) == matrixInput2.GetLength(1))
            {
                
                for(int m = 0;m <matrixOutput.GetLength(0);m++)
                {
                    for(int n = 0; n < matrixOutput.GetLength(1);n++)
                    {
                        matrixOutput[m, n] = 0;
                        for(int i = 0; i<matrixInput1.GetLength(1);i++)
                        {
                            matrixOutput[m, n]+= matrixInput1[m, i] * matrixInput2[i, n];
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong entry");
            }
        }
        
        Random rd = new Random();
        
        
        
    }
}
