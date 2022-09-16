// ####################################################################################################
//                          Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
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

int SumDigit (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}

// Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число: ");

PrintResult("Сумма числа " + num + " равна " + SumDigit(num).ToString());