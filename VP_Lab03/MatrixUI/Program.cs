//double[,] X = new double[2,3] { { 1, 2, 3 }, { 5, 6, 7 } };

//double refX = X[0,0];

//for(int i = 0; i < 6; i++)
//{
//    Console.WriteLine(refX);
//    refX++;
//}

//System.Console.WriteLine("Бабочка");

/// КАК ПОМЕНЯТЬ ПРОБЕЛЫ НА ТАБЫ???

using MatrixLib;


Matrix mtr1 = new Matrix(3, 1);
mtr1[0, 0] = 5;
mtr1[1, 0] = 7;
mtr1[2, 0] = 2;

Console.WriteLine(" Матрица 1:");
Console.WriteLine(mtr1.ToString());
mtr1.Print();

Matrix mtr2 = new Matrix(1, 2);
mtr2[0, 0] = 3;
mtr2[0, 1] = 1;

Console.WriteLine("\n Матрица 2:");
Console.WriteLine(mtr2.ToString());
mtr2.Print();

Matrix mulMtr = mtr1*mtr2;

Console.WriteLine("\n Произведение матриц:");
mulMtr.Print();


/*
Matrix mtr1 = new Matrix(2, 2);
mtr1.Rand();
Matrix mtr2 = mtr1.Clone() as Matrix; //new Matrix(mtr1);

Console.WriteLine(" Матрица 1:");
mtr1.Print();

Console.WriteLine("\n Матрица 2:");
mtr2.Print();


//Console.WriteLine("\n Сложение матриц:");
//(mtr1 + mtr2).Print();

Matrix mtr3 = new Matrix(3, 3);
mtr3.Rand();
Console.WriteLine("\n Матрица 3:");
mtr3.Print();

Console.WriteLine("\n Сравнение матриц:\n");
if (mtr1.CompareTo(mtr2) == 0)
    Console.WriteLine("Матрица 1 равна матрице 2");
else
    Console.WriteLine("Матрица 1 не равна матрице 2");

if (mtr1.CompareTo(mtr3) == 0)
    Console.WriteLine("Матрица 1 равна матрице 3");
else
    Console.WriteLine("Матрица 1 не равна матрице 3");
*/




//Console.WriteLine(mulMtr.ToString());
//Console.WriteLine(mulMtr.ToString(mulMtr.Rows*mulMtr.Columns));

//Console.WriteLine('\n');

//Matrix mtr3 = new Matrix(5, 2);
//mtr3.Rand();
//mtr3.Print();