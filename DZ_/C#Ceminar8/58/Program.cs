// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultArr(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];
    int curSum = 0;
    for (int k = 0; k < array1.GetLength(0); k++)
    {
        for (int l = 0; l < array2.GetLength(1); l++)
        {
            for (int i = 0; i < array1.GetLength(1); i++)
            {
                curSum = curSum + array1[k, i] * array2[i, l];
            }
            res[k, l] = curSum;
            curSum = 0;
        }
    }
    return res;
}

Console.WriteLine("Введите количество строк матрицы А");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы А");
int cols1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[rows1, cols1];
FillArray(array1);
PrintArray(array1);
Console.WriteLine("Введите количество строк матрицы Б");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы Б");
int cols2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[rows2, cols2];
FillArray(array2);
PrintArray(array2);
if (cols1 != rows2)
    Console.WriteLine("Матрицы не совместимы");
else
{
    int[,] res = MultArr(array1, array2);
    Console.WriteLine("Результат умножения матрицы А на матрицу Б ");
    PrintArray(res);
}
