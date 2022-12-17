// задача 2 HARD необязательная. Считается за четыре обязательных )
// то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел
// размерностью m*n (размерность вводим с клавиатуры) ,
// причем чтоб количество элементов было четное.
// Вывести на экран красивенько таблицей.
// Перемешать случайным образом элементы массива,
// причем чтобы каждый элемент гарантированно и только один
// раз переместился на другое место и выполнить перемешивание
// за m*n / 2 итераций. То есть если массив три на четыре,
// то надо выполнить за 6 итераций.
// И далее в конце опять вывести на экран как таблицу.
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

void MixSort(int[,] array)
{
    int[] tmp = new int[array.GetLength(0) * array.GetLength(1)];
    for (int k = 0; k < tmp.Length; k++)
        tmp[k] = -1;

    int ind1 = 0;
    int ind2 = 0;
    for (int i = 0; i <tmp.Length ; i++)
    {
        // Console.WriteLine(i);//проверка количества итераций
            ind1 = new Random().Next(0, tmp.Length / 2);
            while (FindEl(tmp, ind1))
            {
                ind1 = new Random().Next(0, tmp.Length / 2);
            }

            ind2 = new Random().Next(1 + tmp.Length / 2, tmp.Length);
            while (FindEl(tmp, ind1))
            {
                ind2 = new Random().Next(1 + tmp.Length / 2, tmp.Length);
            }
            tmp[i]=ind1;
            i++;
            tmp[i]=ind2;
         (array[ind1/array.GetLength(1),ind1%array.GetLength(1)], array[ind2/array.GetLength(1),ind2%array.GetLength(1)])=(array[ind2/array.GetLength(1),ind2%array.GetLength(1)], array[ind1/array.GetLength(1),ind1%array.GetLength(1)]);
    }
}
bool FindEl(int[] array, int el)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (el == array[i])
            res = true;
    }
    return res;
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows * cols % 2 != 0)
{
    Console.WriteLine("Количество элементов в матрице не чётное");
}
else
{
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    MixSort(array);
    Console.WriteLine();
    PrintArray(array);
}
