using System;

public class LongerLine
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x12 = double.Parse(Console.ReadLine());
        double y12 = double.Parse(Console.ReadLine());
        double x22 = double.Parse(Console.ReadLine());
        double y22 = double.Parse(Console.ReadLine());

        double first = LongestLine(x1, y1, x2, y2);
        double second = LongestLine(x12, y12, x22, y22);

        if (first >= second)
        {
            GetCenterPoint(x1, y1, x2, y2);
        }
        else
        {
            GetCenterPoint(x12, y12, x22, y22);
        }
    }

    private static double LongestLine(double x1, double y1, double x2, double y2)
    {
        double sum = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        return sum;
    }

    private static void GetCenterPoint(double x1, double y1, double x2, double y2)
    {
        double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
        double second = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

        if (first <= second)
        {
            Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
        }
        else
        {
            Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
        }
    }
}
