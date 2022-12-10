// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); //переводим в челочисленное значение введеное с терминала в формате строки.
int[] array = CreateArray(size);
PrintArray(array);
int res = Count_num(size, array);
Console.WriteLine($"в массиве сумма числе на нечетных позициях равна  {res}  ");

// создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size]; //выделение памяти под массив size
    Random rnd = new Random(); //Создание объекта для генерации чисел
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        array[i] = rnd.Next(-1000,1000);
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

//подсчет четных чисел
int Count_num(int size, int[] array)
{
    int result = 0;
    for (int i = 1; i < size; i+=2) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
            result = result + array[i]; //result=result + значение элемента масссива arrey на iтей позиции 
    }
    return result;
}
