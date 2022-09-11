//=====================================
// # 8 Напишите программу, которая на вход принимает число (N),    
// а на выходе показывает все чётные числа от 1 до N.
//=====================================

string? inputLineA = Console.ReadLine();
int number;

if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);
    number = 1;
    while (number < inputNumberA)
    {
        if (number % 2 == 0)
        {
            Console.Write(number + " ");
        }
        number = number + 1;
    } 
    Console.Write(number);   
}   