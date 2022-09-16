
// ####################################################################################################
//                          Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

//* Ввести с клавиатуры длину массива и диапазон значений элементов 
// ####################################################################################################
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возращаем значание
    return number;
}

int [] GenArr(int arrLen, int start, int stop)
    {
        Random rnd = new Random();
        int[] arr = new int[arrLen];
        for (int i = 0; i < arrLen; i++)
        {
            arr[i] = rnd.Next(start, stop+1);
        }
        return arr;
    }

// Печать результата
void PrintResult(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i]+" ");
}

int arrLen = ReadData("Введите длину массиваа:");
int start = ReadData("Введите начальную границу массива:");
int stop = ReadData("Введите конечную границу массива:");

PrintResult(GenArr(arrLen, start, stop));