using System;
using System.Collections.Generic;

public class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());
        string numbers = String.Join(", ", IsPrime(start, stop).ToArray());

        Console.WriteLine(numbers);
    }

    private static List<int> IsPrime(int start, int stop)
    {
        var result = new List<int>();
        for (int i = start; i <= stop; i++)
        {
            bool isPrime = true;

            if (i <= 1)
            {
                isPrime = false;
            }
            else if (i > 2)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
            }
            if (isPrime)
            {
                result.Add(i);

            }
        }
        return result;
    }
}
