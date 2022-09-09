// #############################################################################################
//                          Задача 9
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.
// #############################################################################################

void MyVariant()
{

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int ferstDigit = number / 10;
    int secondDigit = number % 10;
    // Вариант 
    if (ferstDigit > secondDigit)
    {
        Console.WriteLine(ferstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void VariantEvgeniy()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int ferstDigit = number / 10;
    int secondDigit = number % 10;
    // Вариант Евгения
    Console.WriteLine((ferstDigit > secondDigit) ? ferstDigit : secondDigit);
}

void VariatChar()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int ferstDigit = number / 10;
    int secondDigit = number % 10;
    // Вариант char
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine((int)charArray[0] > (int)charArray[1] ? charArray[0] : charArray[1]);
}

MyVariant();
VariantEvgeniy();
VariatChar();