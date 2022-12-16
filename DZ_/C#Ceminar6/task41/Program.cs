// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArray(size);
PrintArray(array);
int res =CountNum( size, array);
Console.WriteLine(
    $"число элементов в массиве больше нуля равно  {res}  "
);

// создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size]; //выделение памяти под массив size
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// вывод на экран
void PrintArray(int[] array)

{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int CountNum (int size,int[] array)
{
    int koll =0;
        foreach (int el in array)
        {
            if (el>0)
            koll=koll+1;
            
        }
        return koll;
}