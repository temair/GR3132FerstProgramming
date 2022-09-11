﻿// ####################################################################################################
//                          Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
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

// Находим растояние между двумя точками
double Calculate(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координату х первой точки: ");
int y1 = ReadData("Введите координату y первой точки: ");
int z1 = ReadData("Введите координату z первой точки: ");
int x2 = ReadData("Введите координату х второй точки: ");
int y2 = ReadData("Введите координату y второй точки: ");
int z2 = ReadData("Введите координату я второй точки: ");

PrintResult("Расстояние между двумя точками: " + Math.Round(Calculate(x1, y1, z1, x2, y2, z2), 2).ToString());