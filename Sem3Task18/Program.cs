// ####################################################################################################
//                          Задача 18
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).
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
string QuoterBorderAsk(int numQuoter)
{
    if (numQuoter == 1)
        return "x>0 y>0";
    if (numQuoter == 2)
        return "x<0 y>0";
    if (numQuoter == 3)
        return "x<0 y<0";
    if (numQuoter == 4)
        return "x>0 y<0";

    return "";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res = QuoterBorderAsk(num);

PrintResult(res);