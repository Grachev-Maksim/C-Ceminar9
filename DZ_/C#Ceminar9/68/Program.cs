// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(m, n);
Console.WriteLine($"вычисление функции Аккермана  {m} и {n}  равна {sum}");

int SumNum(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
            return SumNum(m - 1, 1);
        else
            return SumNum(m - 1, SumNum(m, n - 1));
    }
}
