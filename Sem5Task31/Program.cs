// ####################################################################################################
//                          Задача 31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// ####################################################################################################

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] arr = new int[num];
    //Тест границ
    if (downBorder < topBorder)
    {
        //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    //Возвращаем результат
    return arr;
}

//Печатае одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int[] NegotivPositivSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(inputArray);

int[] sumArray = NegotivPositivSums(inputArray);

PrintResult("Сумма >0: " + sumArray[0] + " Сумма <0: " + sumArray[1]);
Print1DArr(sumArray);

// string RandowArr(int lng, int from, int to)
// {
//     int[] array = new int[lng];
//     Random rnd = new Random();

//     int sunNeg = 0;
//     int sunPos = 0;
//     for (int i = 0; i < lng; i++)
//     {
//         array[i] = rnd.Next(from, to + 1);
//         if (array[i] > 0) sunPos += array[i];
//         else sunNeg += array[i];
//     }

//     return (string.Join(", ", array) + "\n " + sunPos + " " + sunNeg);
// }

// Console.Write(RandowArr(12, -9, 9));