using System;

public class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int fibonacci = GetFibonacci(n);
        Console.WriteLine(fibonacci);
    }

    private static int GetFibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i <= n; i++)
        {
            int temp = a;
            a = b;
            b += temp;
        }
        return a;
    }
}
