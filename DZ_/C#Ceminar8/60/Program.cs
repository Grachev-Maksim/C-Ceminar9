// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// (HARD - случайных уникальных) двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите размер 1");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер 2 ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер 3");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[x, y, z];
CreateArray(array);
PrintArray(array);

// создание массива
void CreateArray(int[,,] array)
{
    Random rnd = new Random(); //Создание объекта для генерации чисел
    bool isexist = false;
    int tmp = 0;
    int i = 0;
    int j = 0;
    int k = 0;
    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            k = 0;
            while (k < array.GetLength(2))
            {
                tmp = rnd.Next(10, 100);
                isexist = FindEl(array, tmp);
                if (!isexist)
                {
                    array[i, j, k] = tmp;
                    k++;
                }
            }
            j++;
        }
        i++;
    }
}

bool FindEl(int[,,] array, int el)
{
    bool res = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (el == array[i, j, k])
                    res = true;
            }
        }
    }
    return res;
}

// вывод на экран
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k], 10} ({i},{j},{k})\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
