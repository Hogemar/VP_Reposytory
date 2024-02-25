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

Matrix mtr2 = new Matrix(1, 2);
mtr2[0, 0] = 3;
mtr2[0, 1] = 1;

Matrix mulmtr = mtr1*mtr2;

Console.WriteLine("aboba");