// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

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

//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Вывод элементов от М до N
string RecLine(int M, int N)
{
    if (M >= N + 1) return "";
    return M + " " + RecLine(M + 1, N);
}

//Вывод суммы элементов от М до N
int RecSum(int M, int N)
{
    if (M >= N + 1) return 0;
    return M + RecSum(M + 1, N);
}

int numM = ReadData("Введите число M ");
int numN = ReadData("Введите число N ");
if (numM < numN)
{
    Console.WriteLine(RecLine(numM, numN));
    PrintResult("Сумма элементов от М до N = " + RecSum(numM, numN));
}
else
{
    Console.WriteLine(RecLine(numN, numM));
    PrintResult("Сумма элементов от N до М = " + RecSum(numN, numM));
}