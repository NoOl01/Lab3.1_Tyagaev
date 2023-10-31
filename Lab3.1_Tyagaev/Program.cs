// Lab 3.1 Номер: 12. Уровень: Средний.
try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double P = 1;
    double S = 0;
    for (int i = 1; i <= k; i++)
    {
        if (i != 3) S += (Math.Pow((-1), i)) / (i - 3);
        for (int n = i; n <= 2*k; n++)
        {
            if (n != 2) P *= (Math.Pow(n, 3) - 8) / (n + 2);
        }
    }
    Console.WriteLine($"W = {S * P:F2}");
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}