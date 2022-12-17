// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

double[] SumArray(int[,] arr)
{
    double[] sum = new double[arr.GetLength(1)];
    double tmp = 0;
    int k = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        tmp = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            tmp = tmp + arr[i, j];
        }
        sum[k] = tmp / arr.GetLength(0);
        k = k + 1;
    }
    return sum;
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
double[] srArray = SumArray(array);
Console.WriteLine("Среднее арифметическое для каждого столбца :\n");
for (int i = 0; i < array.GetLength(1); i++)
    Console.Write($"{srArray[i]} ");
