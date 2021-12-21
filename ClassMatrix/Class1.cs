using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrix
{
    public class ClassMatrix
    {
        int n;
        double[,] A;
        double[,] B;


        public ClassMatrix(int n)
        {
            this.n = n;
            A = new double[n, n];
        }
        public ClassMatrix1(int n)
        {
            this.n = n;
            B = new double[n, n];
        }

        public void Create()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Create1()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2);
                }
            }
        }


        public void Print1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        public static ClassMatrix operator +(ClassMatrix A, ClassMatrix B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }

        public static ClassMatrix operator -(Matrix A, Matrix B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.n; j++)
                {
                    Matrix D[i, j] = A[i, j] - B[i, j];
                }
            }
            return D;
        }

        public static ClassMatrix operator *(Matrix A, Matrix B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.n; j++)
                {
                    ClassMatrix E[i, j] = A[i, j] + B[i, j];
                }
            }
            return E;
        }

    }
}

