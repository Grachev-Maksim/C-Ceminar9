// Задача HARD STAT необязательная: Задайте массив случайных целых чисел.
// Найдите максимальный элемент и его индекс, минимальный элемент
// и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива ,
// возможно придется кое-что для этого дополнительно выполнить
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
double []result=new double[6];
int[] resmax = FindMax(size, array);
int[] resmin = FindMin(size, array);
result[0]=Convert.ToDouble(resmax[0]);
result[1]=Convert.ToDouble(resmax[1]);
result[2]=Convert.ToDouble(resmin[0]);
result[3]=Convert.ToDouble(resmin[1]);
result[4]=Convert.ToDouble(FindMid(size,array));
result[5]=Convert.ToDouble(FindMedian(size,array));
Console.WriteLine($"Максимальный элемент {result[0]} находится на {result[1]} месте ");
Console.WriteLine($"Минимальный элемент {result[2]} находится на {result[3]} месте ");
Console.WriteLine($"Среднее арифметическое значение равно   {result[4]} ");
PrintArray(array);
Console.WriteLine($"Медианное значение массива  равно {result[5]} ");
// создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size]; //выделение памяти под массив size
    Random rnd = new Random(); //Создание объекта для генерации чисел
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        array[i] = rnd.Next(-1000, 1000);
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

//поиск максимума
int[] FindMax(int size, int[] array)
{
    int[] result = new int[2];
    result[0] = array[0];
    result[1] = 0;
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (array[i] > result[0])
        {
            result[0] = array[i];
            result[1] = i;
        }
    }
    return result;
}

//поиск минимума
int[] FindMin(int size, int[] array)
{
    int[] result = new int[2];
    result[0] = array[0];
    result[1] = 0;
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
        if (array[i] < result[0])
        {
            result[0] = array[i];
            result[1] = i;
        }
    }
    return result;
}
// поиск среднего арифметического
double FindMid(int size, int[] array)

{
double result= 0;
    for (int i = 0; i < size; i++) //цикл для от и равного нулю ,до равного сайз минус один , так как знак строго меньше
    {
            result+= array[i];
    }
   result= result/size ;
    return result;
}
int FindMedian(int size, int[] array)
{
SortPuzir(size,array);
int res=0;
if(size%2==0)
{
   res=(array[size/2]+array[size/2-1])/2;
}
else
{
    res=array[size/2];
}
return res ;
}
void SortPuzir(int size, int[] array) 
{
    bool check=true;
    while (check)
    {
        check=false;
      for (int i= 1; i<size;i++)
      {
        if (array[i]<array[i-1])
        {
            check=true;
            array[i]=array[i]+array[i-1];
            array[i-1]=array[i]-array[i-1];
            array[i]=array[i]-array[i-1];
        }
      } 
    }
}