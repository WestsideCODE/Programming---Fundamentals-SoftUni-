using System;

public class GeometryCalculator
{
    static void Main(string[] args)
    {
        string figureType = Console.ReadLine();

        if (figureType == "triangle")
        {
            float side = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area = GetAreaOfTriangle(side, height);
            Console.WriteLine($"{area:F2}");
        }
        else if (figureType == "rectangle")
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area = GetAreaOfRectangle(width, height);
            Console.WriteLine($"{area:F2}");
        }
        else if (figureType == "square")
        {
            float side = float.Parse(Console.ReadLine());
            float area = GetAreaOfSquare(side);
            Console.WriteLine($"{area:F2}");
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double area = GetAreaOfCircle(radius);
            Console.WriteLine($"{area:F2}");
        }
    }

    private static double GetAreaOfCircle(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    private static float GetAreaOfSquare(float side)
    {
        float area = side * side;
        return area;
    }

    private static float GetAreaOfRectangle(float width, float height)
    {
        float area = width * height;
        return area;
    }

    private static float GetAreaOfTriangle(float side, float height)
    {
        float area = side * height / 2;
        return area;
    }
}
