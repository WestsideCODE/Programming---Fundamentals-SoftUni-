using System;

public class EnglishNameOfLastDigits
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(TranslateLastDigit(Math.Abs(n)));

    }

    private static string TranslateLastDigit(long n)
    {
        string number = "";

        switch (FindLastDigitOfN(n))
        {
            case 0:
                number = "zero";
                break;
            case 1:
                number = "one";
                break;
            case 2:
                number = "two";
                break;
            case 3:
                number = "three";
                break;
            case 4:
                number = "four";
                break;
            case 5:
                number = "five";
                break;
            case 6:
                number = "six";
                break;
            case 7:
                number = "seven";
                break;
            case 8:
                number = "eighth";
                break;
            case 9:
                number = "nine";
                break;
        }

        return number;
    }

    private static long FindLastDigitOfN(long n)
    {
        return n % 10;
    }
}
