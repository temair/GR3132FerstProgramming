//=====================================
// # 0 Напишите прошоамму, которая на входе принимает число и
// выдаёт его квадрат (число умноженное на само себя).
//=====================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber * inputNumber;
    Console.WriteLine(outNumber);
}