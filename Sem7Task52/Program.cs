// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.

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
    int[,] array2D = new int[countRow, countColumn];

    if (downBorder < topBorder)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                array2D[i, j] = rnd.Next(downBorder, topBorder + 1);
            }

        }
    }
    return array2D;
}
// Печатаем двумерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Печатаем одномерный массив
void Print1DArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// Вычисляем среднее арифметическое
double[] Count(int[,] arr2D)
{
    double[] array = new double[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            array[j] = array[j] + arr2D[i, j];
        }
    }
    for (int k = 0; k < arr2D.GetLength(1); k++)
    {
        array[k] = array[k] / ((double)arr2D.GetLength(0));
    }
    return array;
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int[,] arr2D = Fill2DArray(row, col, downBorder, topBorder);
Print2DArray(arr2D);
Console.WriteLine();
Print1DArray(Count(arr2D));