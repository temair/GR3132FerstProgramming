// ####################################################################################################
//                          Задача 37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве
// ####################################################################################################
// // Заполняем массив
// int[] GenArray(int arrLength, int start, int stop)
// {
//     int[] array = new int[arrLength];
//     Random ren = new Random();

//     for (int i = 0; i < arrLength; i++)
//     {
//         array[i] = ren.Next(start, stop + 1);
//     }
//     return array;
// }

// // печатаем массив
// void PrintArray(int[] arr)
// {
//     Console.Write("[" + arr[0] + ", ");
//     for (int i = 1; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write(arr[arr.Length - 1] + "]");
//     Console.WriteLine();
// }

// // считаем числа в массиве
// int[] MultTask(int[] arr)
// {
//     int[] arrMult = new int[arr.Length/2];
//     for (int i = 0; i < arr.Length/2; i++)
//     {
//         arrMult[i] = arr[i] * arr[arr.Length-1 -i];
// //     }
// //     return arrMult;
// // }

// // int[] arr = GenArray(50, 1, 1000);

// // PrintArray(arr);
// // int[] outArr = MultTask(arr);
// // PrintArray(outArr);

// // Универсальный метод генерации и заполнение массива
// int[] FillArray(int length, int topBorder, int downBorder)
// {
//     Random rand = new Random();
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(topBorder, downBorder + 1);
//     }
//     return array;
// }

// // подсчитывает произведение пар чисел в одномерном массиве
// int[] MultiOfPairsOfNumbers(int[] array)
// {   
//     int[] outArray = new int[(int)array.Length/2];
//     for (int i = 0; i < outArray.Length; i++)
//     {
//         outArray[i] = array[i] * array[array.Length - i -1];
//     }
//     return outArray;
// }
// // вывод массив
// void Print1DArray(int[] array)
// {
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }


// int[] array = FillArray(10, 0, 30);
// Print1DArray(array);
// Print1DArray(MultiOfPairsOfNumbers(array));
// ---------------------------------------------------------------------
//                                 Задача 38(+)
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
// ---------------------------------------------------------------------

// сравнить метод вставки и метод подсчета по времени
// return arr[arr.Length-1] - arr[0];


// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите 
// разницу между первым и последним элементом. Для задачи со звездочкой 
// использовать заполнение массива целыми числами.


// Генерация случайного массива.
int[] GenArr(int arrLen, int arrMin, int arrMax)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax);
    }
    return arr;
}

// Печать массива
void PrintArr(int[] arr, string message = "Массив: ")
{
    Console.WriteLine($"{message}[{string.Join(", ", arr)}]");
}

// Сортировка вставкой.
int[] InsertSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int currentElement = arr[i];
        int j = i;
        while (j > 0 && arr[j - 1] > currentElement)
        {
            int tmp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = tmp;
            j--;
        }
    }
    return arr;
}

// Сортировка подсчетом.
int[] CountSort(int[] arr)
{
    int max = 5000000;
    int min = 0;

    int[] count = new int[max - min + 1];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[j] = i;
            j++;
        }
    }

    return arr;
}

// Метод для замера времени.
void TimeTest(Func<int[], int[]> Method, int[] arr, string funcName)
{
    DateTime start = DateTime.Now;
    Method(arr);
    Console.WriteLine($"Затраченное время метода {funcName}: {(DateTime.Now - start).TotalMilliseconds} ms");
}


int[] arr = GenArr(100000, 0, 5000000);
//PrintArr(arr);
Console.WriteLine($"Минимальный элемент массива: {arr.Min()}\nМаксимальный элемент массива: {arr.Max()}");
//PrintArr(InsertSort((int[])arr.Clone()), "Массив сортированный методом вставки: ");
//PrintArr(CountSort((int[])arr.Clone()), "Массив сортированный методом подсчета: ");
TimeTest(InsertSort, (int[])arr.Clone(), "InsertSort");
TimeTest(CountSort, (int[])arr.Clone(), "CountSort");