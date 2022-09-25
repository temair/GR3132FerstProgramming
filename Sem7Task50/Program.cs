// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

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
{   //Генератор случайных чисел
    System.Random rnd = new System.Random();
    //Создаем массив
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

// Нахождение элемента по индексу
int FindElement(int row, int column, int[,] array2D)
{
    if ((row < array2D.GetLength(0)) && (column < array2D.GetLength(1)))
    {
        return array2D[row, column];
    }
    else
    {
        return -1;
    }
}

// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
int[,] arr2D = Fill2DArray(row, col, downBorder, topBorder);
Print2DArray(arr2D);
int i = ReadData("Введите номер строки ");
int j = ReadData("Введите номер столбца ");
PrintResult((FindElement(i, j, arr2D) == -1) ? "Элемента с таким индексом нет" : ("Искомый элемент: " + FindElement(i, j, arr2D)));