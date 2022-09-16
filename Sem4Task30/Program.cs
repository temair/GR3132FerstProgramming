
// ####################################################################################################
//                          Задача 30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.
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

// Печать результата
void PrintResult(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i]+" ");
}

    int [] GenArr(int num)
    {
        Random rnd = new Random();
        int[] arr = new int[num];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 2);
        }
        return arr;
    }
    
    PrintResult(GenArr(ReadData("Введите длину массива:")));