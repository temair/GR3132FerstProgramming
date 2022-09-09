// #############################################################################################
//                          Задача 12
// Напишите программу, которая будет принимать на входе два числа и выводить, является ли второе число
// кратным первому, если второе число кратное первому, то программа выводит остаток от деления.
// #############################################################################################

// Вариант Евгения
// void VariantEvgeniy()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = console.ReadLine();

//     int inputLineA = int.Parse(inputLineA);
//     int inputLineB = int.Parse(inputLineB);

//     Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
// }

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

// Получаем два числа от пользователя
void ReadDate()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

// Определяем кратность числа
void ConculaData()
{
    result = (inputNumberB % inputNumberA == 0);
}

// Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}

ReadDate();
ConculaData();
PrintData();

