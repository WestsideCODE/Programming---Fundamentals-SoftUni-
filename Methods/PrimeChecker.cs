using System;

public class PrimeChecker
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        bool isPrime = IsPrime(n);

        Console.WriteLine(isPrime);
    }

    private static bool IsPrime(long n)
    {
        if (n <= 1)
        {
            return false;
        }
        else if (n > 2)
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
