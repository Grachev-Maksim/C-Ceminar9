// задача 1 HARD необязательная. Сгенерировать массив
//  случайных целых чисел размерностью m*n
//  (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей.
//   Найти минимальное число и его индекс,
//  найти максимальное число и его индекс. Вывести эту информацию на экран.

Console.WriteLine("Введите размер массива m");
int m = Convert.ToInt32(Console.ReadLine()); //переводим в челочисленное значение введеное с терминала в формате строки.
Console.WriteLine("Введите размер массива n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateArray(m, n);
PrintArray(array);
int[] resmax=FindMax(array);
int[] resmin=FindMin(array);
Console.WriteLine($"Минимальный элемент {resmin[0]} находится на i={resmin[1]} j={resmin[2]} ");
Console.WriteLine($"Максимальный  элемент {resmax[0]} находится на i={resmax[1]} j={resmax[2]} ");
// Console.WriteLine($"в массиве {res} четных чисел");

// создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n]; //выделение памяти под массив
    Random rnd = new Random(); //Создание объекта для генерации чисел
    for (int i = 0; i < m; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        for (int j = 0; j < n; j++)
            array[i, j] = rnd.Next(-1000, 1000);
    }
    return array;
}

// вывод на экран
void PrintArray(int[,] array)
{
    int tmp = 0;
    string razd = "\n" + String.Concat(Enumerable.Repeat("_", n * 7));
    Console.WriteLine(razd);
    for (int i = 0; i < m; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] >= 0)
                Console.Write($"|{array[i, j]}  ");
            else
                Console.Write($"|{array[i, j]} ");
            if (Math.Abs(array[i, j]) < 1000)
            {
                tmp = Math.Abs(array[i, j]);
                while (tmp < 1000)
                {
                    Console.Write($" ");
                    tmp *= 10;
                }
            }
        }

        Console.WriteLine(razd);
    }
}

//поиск максимума
int[] FindMax(int[,] array)
{
    int[] result = new int[3];
    result[0] = array[0,0];
    result[1] = 0;
    result[2] = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] > result[0])
            {
                result[0] = array[i,j];
                result[1] = i;
                result[2] = j;
            }
        }
    }
    return result;
}

//поиск минимума
int[] FindMin(int[,] array)
{
    int[] result = new int[3];
    result[0] = array[0,0];
    result[1] = 0;
    result[2] = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < result[0])
            {
                result[0] = array[i,j];
                result[1] = i;
                result[2] = j;
            }
        }
    }
    return result;
}
