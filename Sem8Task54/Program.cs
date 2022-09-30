// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Возращает строку масива.
int[] GetRow(int[,] array, int iRow)
{
    int[] row = new int[array.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = array[iRow, j];
    }
    return row;
}

// Заменяет строку масива.
int[,] SetRow(int[,] array, int iRow, int[] row)
{
    for (int j = 0; j < row.Length; j++)
    {
        array[iRow, j] = row[j];
    }
    return array;
}

// Сортировка подсчетом.
int[] CountSort(int[] array)
{
    int max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }

    int[] count = new int[max - min + 1];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] - min]++;
    }

    for (int i = max; i >= min; i--)
    {
        while (count[i - min]-- > 0)
        {
            array[j] = i;
            j++;
        }
    }
    return array;
}

// Сортировка 2D массива.
int[,] Sort2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SetRow(array, i, CountSort(GetRow(array, i)));
    }
    return array;
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int[,] arr2D = Fill2DArray(row, col, downBorder, topBorder);

PrintData("Исходный массив: ");
Print2DArray(arr2D);
PrintData("Сортированный массив: ");
Print2DArray(Sort2DArr(arr2D));