// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

//  Меняем строки со столбцами
int[,] Rotate2DArray(int[,] matr)
{
    int[,] matrix = new int[matr.GetLength(1), matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[j, i] = matr[i, j];
        }
    }
    return matrix;
}

//  Меняем строки со столбцами
int[,] Rotate2DArraySwap(int[,] matr)
{
    int buf = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            buf = matr[j, i];
            matr[j, i] = matr[i, j];
            matr[i, j] = buf;
        }
    }
    return matr;
}

bool TestRot(int[,] matr)
{
    if (matr.GetLength(0) == matr.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
//Print2DArray(matrix);

if (TestRot(matrix))
{
    DateTime d1 = DateTime.Now;
    int[,] matrixChanged1 = Rotate2DArray(matrix);
    Console.WriteLine(DateTime.Now - d1);

    //Print2DArray(matrixChanged1);

    DateTime d2 = DateTime.Now;
    int[,] matrixChanged2 = Rotate2DArraySwap(matrix);
    Console.WriteLine(DateTime.Now - d2);

    //Print2DArray(matrixChanged2);
}
else
{
    Console.WriteLine("Матрицу транспонировать нельзя!");
}