// ФУНКЦИИ ОБЯЗАТЕЛЬНЫ!
// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет
//   количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); //переводим в челочисленное значение введеное с терминала в формате строки.
int[] array = CreateArray(size);
PrintArray(array);
int res = Count_num(size, array);
Console.WriteLine($"в массиве {res} четных чисел");

// создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size]; //выделение памяти под массив size
    Random rnd = new Random(); //Создание объекта для генерации чисел
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        array[i] = rnd.Next(100, 1000);
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
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (array[i] % 2 == 0)
            result = result + 1; //result++ либо либо!
    }
    return result;
}
