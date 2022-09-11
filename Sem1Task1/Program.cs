//=====================================
// # 1 Напишите прошоамму, которая на входе принимает два числа и проверяет,
// является ли первое число квадратом второго.
//=====================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outResult = (inputNumberA * inputNumberA == inputNumberB);

    Console.WriteLine(outResult);
}