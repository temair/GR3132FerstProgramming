// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

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

// Универсальный метода генерации и заполнения двумерного массива вещественными числами
double[,] Fill2DArrayReal(int countRow, int countColumn, int downBorder, int topBorder)
{
    // Генератор случайных чисел
    Random rnd = new Random();
    // Создаем массив
    double[,] array2D = new double[countRow, countColumn];
    int range = downBorder - topBorder;
    // Заполнение массива
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {// Для заполнения массива запрашиваем вещественные числа NextDouble()
            array2D[i, j] = rnd.Next(downBorder, topBorder) + rnd.NextDouble();
        }
    }
    return array2D;
}

// Печатаем двумерный массив
void Print2DArray(double[,] array)
{
    ConsoleColor[] color = new ConsoleColor[]
        { ConsoleColor.DarkGreen, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta,
        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.Blue,
        ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Magenta,
        ConsoleColor.Yellow, ConsoleColor.White};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = color[new System.Random().Next(0, 12)];
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int col = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массивва: ");
int topBorder = ReadData("Введите верхнюю границу массивва: ");
double[,] arr2D = Fill2DArrayReal(row, col, downBorder, topBorder);
Print2DArray(arr2D);