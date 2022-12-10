// Задача 30: - HARD необязательная Напишите программу,
// которая на вход получает размерность массива.
// Далее заполняет его случайными уникальными числами и
// выводит на экран. Далее производим сортировку массива
// от большего к меньшему и выводим на экран.
// Далее придумываем алгоритм перемешивания списка на основе случайности ,
// применяем этот алгоритм и выводим на экран результат.
// Встроенные методы работы со списками использовать нельзя.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
SortPuzir(size, array);
PrintArray(array);
MixArray(size, array);
PrintArray(array);

// создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size]; //выделение памяти под массив size
    Random rnd = new Random(); //Создание объекта для генерации чисел
    bool isexist = false;
    int tmp = 0;
    int i = 0;
    while (i < size) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        tmp = rnd.Next(-1000, 1000);
        isexist = FindEl(i, array, tmp);
        if (!isexist)
        {
            array[i] = tmp;
            i++;
        }
    }
    return array;
}

bool FindEl(int size, int[] array, int el)
{
    bool res = false;
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (el == array[i])
            res = true;
    }
    return res;
}

// вывод на экран
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void SortPuzir(int size, int[] array)
{
    bool check = true;
    while (check)
    {
        check = false;
        for (int i = 1; i < size; i++)
        {
            if (array[i] > array[i - 1])
            {
                check = true;
                array[i] = array[i] + array[i - 1];
                array[i - 1] = array[i] - array[i - 1];
                array[i] = array[i] - array[i - 1];
            }
        }
    }
}
void MixArray(int size, int[] array)
{
    int[] arrayindex = new int[size]; //выделение памяти под массив size

    Random rnd = new Random(); //Создание объекта для генерации чисел
    bool isexist = false;
    int tmp = 0;
    int i = 0;
    while (i < size) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        tmp = rnd.Next(0, size);
        isexist = FindEl(i, arrayindex, tmp);
        if (!isexist)
        {
            arrayindex[i] = tmp;
            i++;
        }
    }
    int index1 = 0;
    int index2 = 0;
    for (int j = 1; j < size; j += 2)
    {
        index1 = arrayindex[j - 1];
        index2 = arrayindex[j];
        array[index1] = array[index1] + array[index2];
        array[index2] = array[index1] - array[index2];
        array[index1] = array[index1] - array[index2];
    }
}
