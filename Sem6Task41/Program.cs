// ####################################################################################################
//                          Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
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

//Анализ чисел на положительность и подсчет тех, что >0
int Count(int num)
{
    int res = 0;
    for (int i = 0; i < num; i++)
    {
        int number = ReadData($"Введите {i + 1}е число:");
        if (number > 0)
        {
            res++;
        }
    }
    return res;
}

//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int countNum = ReadData("Введите количество чисел:");
PrintResult("Количество чисел больше нуля = " + Count(countNum));