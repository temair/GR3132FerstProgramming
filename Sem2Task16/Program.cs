// #############################################################################################
//                          Задача 16
// Напишите программу, которая принимает на вход два числа и проверяет является ли 
// одго число квадратом другого числа
// #############################################################################################

// чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаеи\м значание
    return number;
}

// Тест на квадрат
bool SqrTest(int festNum, int secondNum)
{
    if (festNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}


// Вывод данных
void PrintDate(int festNum, int secondNum)
{
    if (SqrTest(festNum, secondNum))
    {
        Console.WriteLine("Число " + festNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + festNum + " не квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");

PrintDate(num1, num2);
PrintDate(num2, num1);