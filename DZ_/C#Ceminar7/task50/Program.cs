// Задача 50. Напишите программу, которая на вход принимает
// значение элемента в двумерном массиве, и возвращает
// позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
int[] FindElArray(int el, int[,] array)
{
    int[] res = { -1, -1 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (el == array[i, j])
            {
                res[0] = i;
                res[1] = j;
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
Console.WriteLine("Введите значение элемента для поиска");
int el = Convert.ToInt32(Console.ReadLine());
int[] ar = FindElArray(el, array);
if (ar[0] != -1)
    Console.WriteLine($"Элемент на ходится на позиции {ar[0]} {ar[1]}");
else
    Console.WriteLine($"Элемент не найден");
