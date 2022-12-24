// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с
//  наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int FindMinCol(int[,] array)
{
    int curSum = 0;
    int minSum = 0;
    int res = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            curSum = curSum + array[i, j];
        }
        if (i == 0)
        {
            minSum = curSum;
            res = i;
        }
        else
        {
            if (curSum < minSum)
            {
                minSum = curSum;
                res = i;
            }
        }
    }
    return res;
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
if (rows == cols)
    Console.WriteLine("Матрица квадратная");
else
{
    int colMin = FindMinCol(array);
    Console.WriteLine($"Cтрокa с наименьшей суммой элементов {colMin+1} (строки начинаем считать с 1)");
}
