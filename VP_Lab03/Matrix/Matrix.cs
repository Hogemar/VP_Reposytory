using System.Text;

namespace MatrixLib
{
    public class Matrix
    {
        private double[,] _elements; // Массив значений
        public uint Rows { get; private set; } // Количество строк
        public uint Columns { get; private set; } // Количество столбцов

        // Конструктор с задаваемыми размерами
        public Matrix(uint rows, uint columns)
        {
            this.Rows = rows;
            this.Columns = columns;

            _elements = new double[Rows, Columns];

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    _elements[i, j] = 0;
        }

        // Конструктор копирования
        public Matrix(Matrix matrix)
        {
            this.Rows = matrix.Rows;
            this.Columns = matrix.Columns;

            _elements = new double[Rows, Columns];

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    _elements[i, j] = matrix._elements[i,j];
        }

        // Индексатор доступа к элементам
        public double this[uint row, uint column]
        {
            get
            {
                if (row < 0 || row >= Rows) throw new Exception("get: 'row' argument out of range!");
                if (column < 0 || column >= Columns) throw new Exception("get: 'column' argument out of range!");

                return _elements[row, column];
            }
            set
            {
                if (row < 0 || row >= Rows) throw new Exception("set: 'row' argument out of range!");
                if (column < 0 || column >= Columns) throw new Exception("set: 'column' argument out of range!");

               _elements[row, column] = value;
            }
        }

        // Возврат строки с количеством строк, столбцов и элементов
        public override string ToString()
        {
            return $" Матрица:" +
                $"\nКоличество строк: {Rows}" +
                $"\nКоличество столбцов: {Columns}" +
                $"\nКоличество элементов: {Rows*Columns}";
        }

        // Возврат n первых элементов в одной строке
        public string ToString(uint n)
        {
            StringBuilder nValuesStringBuilder = new StringBuilder(); /// Название получше???
            uint i = 0;
            foreach (var value in _elements)
            {
                nValuesStringBuilder.Append(value);
                nValuesStringBuilder.Append(' ');
                if (++i >= n) break;
            }
            return nValuesStringBuilder.ToString();
        }

        // Возвращает результат сложения двух матриц
        public static Matrix operator +(Matrix left, Matrix right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns) throw new Exception("operator+: matrices must have equal dimensions!");

            Matrix result = new Matrix(left);
            for (uint i = 0; i < result.Rows; i++)
                for (uint j = 0; j < result.Rows; j++)
                    result[i, j]+= right[i, j];

            return result;
        }

        // Возвращает результат вычитания правой матрицы из левой
        public static Matrix operator -(Matrix left, Matrix right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns) throw new Exception("operator-: matrices must have equal dimensions!");

            Matrix result = new Matrix(left);
            for (uint i = 0; i < result.Rows; i++)
                for (uint j = 0; j < result.Rows; j++)
                    result[i, j]-= right[i, j];

            return result;
        }

        // Возвращает результат произведения левой матрицы на правую
        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Columns != right.Rows) throw new Exception("operator*: left matrix columns number must be equal to right matrix rows number!");

            Matrix result = new Matrix(left.Rows, right.Columns);

            for (uint i = 0; i < (result.Rows); i++)
                for (uint j = 0; j < (result.Columns); j++)
                {
                    double c = 0;

                    for (uint k = 0; k < right.Rows; k++)
                        c += left[i,k] * right[k, j];

                    result[i, j] = c;
                }

            return result;
        }
    }
}
