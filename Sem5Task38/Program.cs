// ####################################################################################################
//                          Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// ####################################################################################################

int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значание
    return number;
}

// Генерация случайного массива.
double[] GenArr(int arrLen)
{
    double[] arr = new double[arrLen];
    Random rnd = new Random();

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return arr;
}

// Печать массива
void PrintResult(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int arrLen = ReadData("Введите длину массиваа:");

double[] arr = GenArr(arrLen);
PrintResult(arr);
double dif = Math.Round(arr.Max(), 1) - Math.Round(arr.Min(), 1);
Console.WriteLine($"Разница между минимальным элементом массива: {Math.Round(arr.Min(), 1)} и максимальным элементом массива: {Math.Round(arr.Max(), 1)} равна: {dif}");
