// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortPuzir(int line, int[,] array)
{
    bool check = true;
    while (check)
    {
        check = false;
        for (int i = 1; i < array.GetLength(1); i++)
        {
            if (array[line, i] > array[line, i - 1])
            {
                check = true;
                (array[line, i], array[line, i - 1]) = (array[line, i - 1], array[line, i]);
                // array[line, i] = array[line, i] + array[line, i - 1];
                // array[line, i - 1] = array[line, i] - array[line, i - 1];
                // array[line, i] = array[line, i] - array[line, i - 1];
            }
        }
    }
}
void PreSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortPuzir(i, array);
    }
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
PreSort(array);
Console.WriteLine("Упорядоченный  массив");
PrintArray(array);
