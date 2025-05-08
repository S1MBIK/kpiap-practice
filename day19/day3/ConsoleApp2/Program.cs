using System;

namespace MatrixApp 
{
    public class Matrix
    {
        private double[,] elements; 
        public int Rows { get; private set; } 
        public int Columns { get; private set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            elements = new double[rows, columns];
        }

        public double this[int row, int column]
        {
            get => elements[row, column];
            set => elements[row, column] = value;
        }

        public double SumMainDiagonal()
        {
            double sum = 0;
            for (int i = 0; i < Math.Min(Rows, Columns); i++)
            {
                sum += elements[i, i];
            }
            return sum;
        }

        public static bool operator >(Matrix a, Matrix b)
        {
            return a.SumMainDiagonal() > b.SumMainDiagonal();
        }

        public static bool operator <(Matrix a, Matrix b)
        {
            return a.SumMainDiagonal() < b.SumMainDiagonal();
        }
    }

    class Program
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix(3, 3);
            matrix1[0, 0] = 1;
            matrix1[1, 1] = 2;
            matrix1[2, 2] = 3;

            Matrix matrix2 = new Matrix(3, 3);
            matrix2[0, 0] = 4;
            matrix2[1, 1] = 5;
            matrix2[2, 2] = 6;

            Console.WriteLine($"Сумма главной диагонали Matrix1: {matrix1.SumMainDiagonal()}");
            Console.WriteLine($"Сумма главной диагонали Matrix2: {matrix2.SumMainDiagonal()}");

            if (matrix1 > matrix2)
            {
                Console.WriteLine("Matrix1 имеет большую сумму главной диагонали, чем Matrix2.");
            }
            else if (matrix1 < matrix2)
            {
                Console.WriteLine("Matrix1 имеет меньшую сумму главной диагонали, чем Matrix2.");
            }
            else
            {
                Console.WriteLine("Суммы главной диагонали Matrix1 и Matrix2 равны.");
            }
        }
    }
}