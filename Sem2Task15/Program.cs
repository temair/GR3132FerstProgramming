// #############################################################################################
//                          Задача 15
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// #############################################################################################

int inputNumber = 0;

// Получаем цифру от пользователя
void ReadDate()
{
    Console.Write("Введите число дня недели: ");
    string? inputLine = Console.ReadLine();
    inputNumber = int.Parse(inputLine);
}

// Выводим данные вычисления
void PrintData()
{
    if (inputNumber >= 1 && inputNumber <= 7)
    {
        if (inputNumber == 6 || inputNumber == 7)
        {
            Console.Write("Выходной день");
        }
        else
        {
            Console.Write("Будний день");
        }

    }
    else
    {
        Console.Write("Такого дня недели нет");
    }

}

ReadDate();
PrintData();

