﻿// #############################################################################################
//                          Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// #############################################################################################

string number = "";

// Получаем число от пользователя
void ReadDate()
{
    Console.Write("Введите трёхзначное число: ");
    number = Console.ReadLine();

}

// Выводим результат
void PrintData()
{
    if (number.Length == 3)
    {
        char[] charArray = number.ToString().ToCharArray();
        Console.Write(charArray[1]);
    }
    else Console.WriteLine("Вы ввели не трёзначное число");
}

ReadDate();
PrintData();