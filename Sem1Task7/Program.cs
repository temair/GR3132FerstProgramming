//=====================================
// # 5 Напишите программу, которая на входе принимает  одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
//=====================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int lastDigit = inputNumber%10;
        Console.WriteLine(lastDigit);    
    }
}