// ####################################################################################################
//                          Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; 5,5)
// *Найдите площадь треугольника образованного пересечением 3 прямых
// ####################################################################################################

// чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значание
    return number;
}

//Поиск точки пересечения
double[] PointFind(double k1, double k2, double b1, double b2)
{
    double[] outArr = new double[2];
    outArr[0] = (b1 - b2) / (k2 - k1);
    outArr[1] = outArr[0] * k1 + b1;
    return outArr;
}

//Печатаем одномерный массив
void Print1DArray(string line, double[] array)
{
    Console.WriteLine(line);
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1]);
}

double k1 = ReadData("Введите k1: ");
double k2 = ReadData("Введите k2: ");
double b1 = ReadData("Введите b1: ");
double b2 = ReadData("Введите b2: ");
Print1DArray("Координаты точки пересечения: ", PointFind(k1, k2, b1, b2));