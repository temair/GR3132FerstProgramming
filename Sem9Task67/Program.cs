// Задача 67: Задайте значение N. Напишите программу, которая будет принимать N и возращать сумму его чисел.

// // Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int SumDigit(int num)
// {
//     if (num / 10 == 0)
//         return num;
//     return SumDigit(num / 10) + num % 10;
// }

// int number = ReadData("Введите число: ");
// int sum = SumDigit(number);
// PrintResult("Сумма цифр в числе: "+sum);

// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";
    return int.Parse(inputLine);
}

// возвращает сумму цифр числа numN
int RecSumDigit(int numN)
{
    return numN == 0 ? 0 : numN % 10 + RecSumDigit(numN / 10);
}

// Вывод в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

PrintResult(RecSumDigit(ReadData("Введите число")));