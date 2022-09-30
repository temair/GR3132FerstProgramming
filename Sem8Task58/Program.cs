// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Универсальный метода генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{   // Генератор случайных чисел
    System.Random rnd = new System.Random();
    // Создаем массив
    int[,] array2Day2D = new int[countRow, countColumn];

    if (downBorder < topBorder)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                array2Day2D[i, j] = rnd.Next(downBorder, topBorder + 1);
            }

        }
    }
    return array2Day2D;
}

// Печатаем двумерный массив
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Возращает строку масива.
int[] GetRow(int[,] array2D, int iRow)
{
    int[] row = new int[array2D.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = array2D[iRow, j];
    }
    return row;
}

// Возращает Столбец масива.
int[] GetColumn(int[,] array2D, int iRow)
{
    int[] row = new int[array2D.GetLength(0)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = array2D[j, iRow];
    }
    return row;
}

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Сумма элементов 1D массива.
int Sum(int[] array2D)
{
    int sum = 0;
    for (int i = 0; i < array2D.Length; i++)
    {
        sum += array2D[i];
    }
    return sum;
}

// Поэлементное произведение массивов.
int[] Multiplication(int[] array2DA, int[] array2DB)
{
    int[] result = new int[array2DA.Length];
    for (int i = 0; i < array2DA.Length; i++)
    {
        result[i] = array2DA[i] * array2DB[i];
    }
    return result;
}

// Произведение Матриц.
int[,] MatrixMultiplication(int[,] array2DA, int[,] array2DB)
{
    int[,] result = new int[array2DA.GetLength(0), array2DB.GetLength(1)];
    if (array2DA.GetLength(1) == array2DB.GetLength(0))
    {

        for (int i = 0; i < array2DA.GetLength(0); i++)
        {
            for (int j = 0; j < array2DB.GetLength(1); j++)
            {
                result[i, j] = Sum(Multiplication(GetRow(array2DA, i), GetColumn(array2DB, j)));
            }
        }
        return result;
    }
    return null;
}

int rowA = ReadData("Введите количество строк матрицы A ");
int colA = ReadData("Введите количество столбцов матрицы A ");
int downBorderA = ReadData("Введите нижнюю границу матрицы A: ");
int topBorderA = ReadData("Введите верхнюю границу матрицы A: ");
int[,] array2DA = Fill2DArray(rowA, colA, downBorderA, topBorderA);
PrintData("Матрица А: ");
Print2DArray(array2DA);

int rowB = ReadData("Введите количество строк матрицы B ");
int colB = ReadData("Введите количество столбцов матрицы B ");
int downBorderB = ReadData("Введите нижнюю границу матрицы B: ");
int topBorderB = ReadData("Введите верхнюю границу матрицы B: ");
int[,] array2DB = Fill2DArray(rowB, colB, downBorderB, topBorderB);
PrintData("Матрица B: ");
Print2DArray(array2DB);

PrintData("Произведение матриц AxB: ");
Print2DArray(MatrixMultiplication(array2DA, array2DB));