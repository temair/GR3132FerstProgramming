// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

// Метод считывания данных пользователя
uint ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    uint number = uint.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Вычисление функции Аккермана по m, n
ulong FunctionAkkerman(uint m, uint n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionAkkerman(m - 1, 1);
    return FunctionAkkerman(m - 1, (uint)FunctionAkkerman(m, n - 1));
}

uint numM = ReadData("Введите число m ");
uint numN = ReadData("Введите число n ");
Console.WriteLine($"A({numM},{numN}) = " + FunctionAkkerman(numM, numN));