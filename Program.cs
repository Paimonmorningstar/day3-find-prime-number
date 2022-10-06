using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, x, y;
        Console.Write("Add a= ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add b= ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add x= ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add y= ");
        y = Convert.ToInt32(Console.ReadLine());

        Task.WhenAll(
            FindPrimeNumbers(a, b),
            FindPrimeNumbers(x, y)
        );
        Console.ReadKey();
        Console.WriteLine("done");
    }
    static async Task FindPrimeNumbers(int min, int max)
    {
        await Task.Run(() =>
        {
            for (int i = min; i <= max; i++)
            {
                if (PrimeNumber(i))
                {
                    Console.WriteLine(" " + i);
                }
            }
        });
    }
    static bool PrimeNumber(int p)
    {
        for (int i = 2; i < p / 2; i++)
        {
            if (p % i == 0)
            {
                return false;
            }
        }
        if (p < 2)
        {
            return false;
        }
        return true;
    }
}
