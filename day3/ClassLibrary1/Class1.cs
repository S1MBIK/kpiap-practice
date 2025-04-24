using System;

namespace MatrixApp // Оберните код в пространство имен
{
    public class Matrix
    {
        private double[,] elements; // Скрытое поле для хранения элементов матрицы
        public int Rows { get; private set; } // Открытое поле для количества строк
        public int Columns { get; private set; } // Открытое поле для количества столбцов

        // Конструктор
        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            elements = new double[rows, columns];
        }

        // Индексатор для доступа к элементам матрицы
        public double this[int row, int column]
        {
            get => elements[row, column];
            set => elements[row, column] = value;
        }

        // Метод для вычисления суммы элементов главной диагонали
        public double SumMainDiagonal()
        {
            double sum = 0;
            for (int i = 0; i < Math.Min(Rows, Columns); i++)
            {
                sum += elements[i, i];
            }
            return sum;
        }

        // Перегрузка оператора >
        public static bool operator >(Matrix a, Matrix b)
        {
            return a.SumMainDiagonal() > b.SumMainDiagonal();
        }

        // Перегрузка оператора <
        public static bool operator <(Matrix a, Matrix b)
        {
            return a.SumMainDiagonal() < b.SumMainDiagonal();
        }
    }

}