using System.Text;

namespace MatrixLib
{
    public class Matrix : ICloneable, IComparable
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
                    _elements[i, j] = matrix._elements[i, j];
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
            return
                $"Количество строк: {Rows}" +
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
                        c += left[i, k] * right[k, j];

                    result[i, j] = c;
                }

            return result;
        }

        // Реализация метода Clone интерфейса ICloneable
        public object Clone()
        {
            return new Matrix(this);
        }

        // Реализация метода CompareTo интерфейса ICompareable
        // Возвращает:
        // 0 – Матрицы равны или это один объект
        // 1 – Матрицы равных размеров, сумма вызывающей матрицы больше
        // -1 – Матрицы равных размеров, сумма вызывающей матрицы меньше
        // 2 – Вызывающая матрица больше по размерам
        // -2 – Вызывающая матрица меньше по размерам
        public int CompareTo(object? obj)
        {
            if (obj == null) throw new Exception("CompareTo: object is null!");
            if (obj == this) return 0;

            Matrix matrixObject = obj as Matrix;

            if (this.Rows != matrixObject.Rows || this.Columns != matrixObject.Columns)
                return (this.Rows * this.Columns > matrixObject.Rows * matrixObject.Columns) ? 2 : -2;

            bool unequalSum = false;

            for (uint i = 0; i < Rows && !unequalSum; i++)
                for (uint j = 0; j < Columns && !unequalSum; j++)
                    if (this._elements[i, j] != matrixObject._elements[i, j]) unequalSum = true;

            if (unequalSum)
            {
                double sumMain = 0, sumObj = 0;

                foreach (var element in this._elements)
                    sumMain += element;
                foreach (var element in matrixObject._elements)
                    sumObj += element;

                return (sumMain > sumObj) ? 1 : -1;
            }


            return 0;
        }

        // Вывод матрицы в консоль
        public void Print()
        {
            Console.Write(' ');
            for (int j = 0; j < Columns; j++)
                for (int i = 0; i < 7; i++)
                    Console.Write("_");
            Console.WriteLine();
            for (int i = 0; i < (Rows); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write("| ");
                    Console.Write("{0:F2}", Math.Round(_elements[i, j],2).ToString().PadLeft(5));
                }
                Console.WriteLine("|");
                Console.Write(' ');
                for (int j = 0; j < Columns; j++)
                    for (int k = 0; k < 7; k++)
                        Console.Write("_");
                Console.WriteLine();
            }
        }

        // Заполнение матрицы случайными числами
        public void Rand()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < (Columns); j++)
                    _elements[i, j] = Math.Round(rnd.Next(0, 51) * Math.Pow(-1, rnd.Next(1, 3)) * 0.4856, 3);
        }
    }
}
