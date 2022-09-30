// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Сумма элементов 1D массива.
int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

// Возращает строку масива.
int[] GetRow(int[,] arr, int iRow)
{
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[iRow, j];
    }
    return row;
}

// Минимальная сумма в строке.
int MinSumInRow(int[,] arr)
{
    int min = Sum(GetRow(arr, 0));
    int iMin = 0;
    int currentSum;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        currentSum = Sum(GetRow(arr, i));
        if (currentSum < min)
        {
            min = currentSum;
            iMin = i;
        }
    }
    return iMin;
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int[,] arr2D = Fill2DArray(row, col, downBorder, topBorder);

Print2DArray(arr2D);
PrintData(MinSumInRow(arr2D).ToString(), "Строка с наименьшей суммой элементов: ");