// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
Spin(array);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]}\t");
            else
                Console.Write($"{array[i, j], 2}\t");
        }

        Console.WriteLine();
    }
}

void Spin(int[,] arr)
{
    int proxod = 0;
    int i = 0;
    int j = 0;
    int curr = arr.GetLength(0);
    int tmp = 1;
    while (tmp <= arr.GetLength(0) * arr.GetLength(0))
    {
        i = proxod;
        j = proxod;
        if ((i == proxod) && (j == proxod))
        {
            while (j < curr)
            {
                arr[i, j] = tmp;
                tmp = tmp + 1;
                j = j + 1;
            }
        }
        if ((j == curr) && (i == proxod))
        {
            i = i + 1;
            j = j - 1;
            while (i < curr)
            {
                arr[i, j] = tmp;
                tmp = tmp + 1;
                i = i + 1;
            }
        }
        if ((j == curr - 1) && (i == curr))
        {
            i = i - 1;
            j = j - 1;
            while (j >= proxod)
            {
                arr[i, j] = tmp;
                tmp = tmp + 1;
                j = j - 1;
            }
        }
        if ((i == curr - 1) && (j == proxod - 1))
        {
            i = i - 1;
            j = j + 1;
            while (i > proxod)
            {
                arr[i, j] = tmp;
                tmp = tmp + 1;
                i = i - 1;
            }
        }
        proxod = proxod + 1;
        curr = curr - 1;
    }
}
