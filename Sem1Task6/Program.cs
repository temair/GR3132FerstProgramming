//=====================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт,   
// является ли число чётным (делится ли оно на два без остатка).
//=====================================

string? inputLineA = Console.ReadLine();
int result;

if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);

    result = inputNumberA % 2;
    
    if (result == 0)
    {
        Console.WriteLine("Число " + inputNumberA + " является чётным");
    } 
    else 
        Console.WriteLine("Число " + inputNumberA + " не является чётным");
}