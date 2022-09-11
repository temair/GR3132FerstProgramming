// ####################################################################################################
//                          Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
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
// 
bool PalindromTest(int NumberPol)
{
    if ((NumberPol / 10000 == NumberPol % 10) && ((NumberPol / 1000) % 10) == ((NumberPol / 10) % 10))
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int NumberPol = ReadData("Введите пятичзначное число");
PrintResult(PalindromTest(NumberPol).ToString());