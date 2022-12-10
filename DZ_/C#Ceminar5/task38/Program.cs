// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); //переводим в челочисленное значение введеное с терминала в формате строки.
double[] array = CreateArray(size);
PrintArray(array);
double resmax = FindMax(size, array);
double resmin = FindMin(size, array);
Console.WriteLine(
    $"Разница между максмимальным {resmax}  и минимальным {resmin} элементом массива  {resmax - resmin}  "
);

// создание массива
double[] CreateArray(int size)
{
    double[] array = new double[size]; //выделение памяти под массив size
    Random rnd = new Random(); //Создание объекта для генерации чисел
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        array[i] = rnd.NextDouble() * (1024 - (-1024)) + (-1024); //NextDouble делает рандом от 0 до 1 ,а (1024-(-1024))+(-1024) расширяет диапазон от -1024 до 1024 ! 24 выбрана для красоты , тюк является степенью двойки .
    }
    return array;
}

// вывод на экран
void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

//поиск максимумв
double FindMax(int size, double[] array)
{
    double result = array[0];
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (array[i] > result)
            result = array[i];
    }
    return result;
}

//поиск минимума
double FindMin(int size, double[] array)
{
    double result = array[0];
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (array[i] < result)
            result = array[i];
    }
    return result;
}
