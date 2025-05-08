using System;

namespace MatrixApp 
{
    /// <summary>
    /// Класс для работы с матрицами
    /// </summary>
    public class Matrix
    {
        private double[,] elements; 
        /// <summary>
        /// Количество строк в матрице
        /// </summary>
        public int Rows { get; private set; } 
        /// <summary>
        /// Количество столбцов в матрице
        /// </summary>
        public int Columns { get; private set; } 

        /// <summary>
        /// Создает новый экземпляр матрицы с указанными размерами
        /// </summary>
        /// <param name="rows">Количество строк</param>
        /// <param name="columns">Количество столбцов</param>
        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            elements = new double[rows, columns];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы
        /// </summary>
        /// <param name="row">Индекс строки</param>
        /// <param name="column">Индекс столбца</param>
        /// <returns>Элемент матрицы по указанным индексам</returns>
        public double this[int row, int column]
        {
            get => elements[row, column];
            set => elements[row, column] = value;
        }

        /// <summary>
        /// Вычисляет сумму элементов главной диагонали матрицы
        /// </summary>
        /// <returns>Сумма элементов главной диагонали</returns>
        public double SumMainDiagonal()
        {
            double sum = 0;
            for (int i = 0; i < Math.Min(Rows, Columns); i++)
            {
                sum += elements[i, i];
            }
            return sum;
        }

        /// <summary>
        /// Оператор сравнения "больше" для матриц
        /// </summary>
        /// <param name="a">Первая матрица</param>
        /// <param name="b">Вторая матрица</param>
        /// <returns>True, если сумма элементов главной диагонали первой матрицы больше</returns>
        public static bool operator >(Matrix a, Matrix b)
        {
            return a.SumMainDiagonal() > b.SumMainDiagonal();
        }

        /// <summary>
        /// Оператор сравнения "меньше" для матриц
        /// </summary>
        /// <param name="a">Первая матрица</param>
        /// <param name="b">Вторая матрица</param>
        /// <returns>True, если сумма элементов главной диагонали первой матрицы меньше</returns>
        public static bool operator <(Matrix a, Matrix b)
        {
            return a.SumMainDiagonal() < b.SumMainDiagonal();
        }
    }
}