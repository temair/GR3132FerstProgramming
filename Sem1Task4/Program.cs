//=====================================
// # 4 Напишите программу, которая принимает на вход три числа  
// и выдаёт максимальное из этих чисел.
//=====================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null &&  inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    
    if (inputNumberA > inputNumberB)
    {
        if (inputNumberA > inputNumberC)
            Console.WriteLine("Число " + inputNumberA + " больше числа " + inputNumberB + " и больше числа " + inputNumberC);
        else
            Console.WriteLine("Число " + inputNumberC + " больше числа " + inputNumberA + " и больше числа " + inputNumberB);
    } 
    else 
        if (inputNumberB > inputNumberC)
            Console.WriteLine("Число " + inputNumberB + " больше числа " + inputNumberA + " и больше числа " + inputNumberC);
        else  Console.WriteLine("Число " + inputNumberC + " больше числа " + inputNumberA + " и больше числа " + inputNumberB);

}