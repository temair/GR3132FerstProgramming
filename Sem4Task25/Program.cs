// ####################################################################################################
//                          Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
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

long Pow (int NumberA, int NumberB)
{
    long res = 1;
    for (int i = 0; i < NumberB; i++)
    {
        res = res * NumberA;
      
    }
    return res;
}

// Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int NumberA = ReadData("Введите число: ");
int NumberB = ReadData("Введите степень: ");

PrintResult("Число "+NumberA+" в степени "+NumberB+" равно " + Pow(NumberA, NumberB));