// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n}  равна {sum}");

int SumNum(int m, int n)
{
    if (m <= n)
    {
        return m + SumNum(m + 1, n);
    }
    else
    {
        return 0;
    }
}
