// #############################################################################################
//                          Задача 14


// #############################################################################################

// чтение данных из консоли
void ReadData()
{
    number = RequestNumber("Enter number");
}

// Определяем кратность числа
void CalculateData()
{
    resultA = number % 7;
    resultB = number % 23;
}

// Вывод данных
void PrintDate()
{
    if (resultA == 0 && resultB == 0)
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}

ReadData();
CalculateData();
PrintDate();