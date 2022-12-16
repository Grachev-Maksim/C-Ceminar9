// Задача 43: Напишите программу,
//  которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите угловой коофициент k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коофициент смещения b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коофициент k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коофициент смещения b2");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
    Console.WriteLine($"прямые y={k1}*x+{b1} ,y={k2}*x+{b2} парраллены ");
else
{
    double[] coord = peresechenie(k1, b1, k2, b2);
    Console.WriteLine(
        $"прямые y={k1}*x+{b1} ,y={k2}*x+{b2} пересекаются в точке ({coord[0]},{coord[1]})"
    );
}

double[] peresechenie(double k1, double b1, double k2, double b2)
{
    double[] per = new double[2];
    per[0] = (b2 - b1) / (k1 - k2);
    per[1] = (k1 * per[0] + b1);
    return per;
}
