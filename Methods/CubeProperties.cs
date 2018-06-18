using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CubeProperties
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string perimeter = Console.ReadLine();

            switch (perimeter)
            {
                case "face":
                    GetFaceDiagonals(value);
                    break;
                case "volume":
                    GetVolume(value);
                    break;
                case "space":
                    GetSpace(value);
                    break;
                case "area":
                    GetSurface(value);
                    break;
                default:
                    break;
            }
        }

        private static void GetSurface(double value)
        {
            double surface = 6 * (value * value);
            Console.WriteLine($"{surface:F2}");
        }

        private static void GetSpace(double value)
        {
            double space = Math.Sqrt(3 * Math.Pow(value, 2));
            Console.WriteLine($"{space:F2}");
        }

        private static void GetVolume(double value)
        {
            double volume = value * value * value;
            Console.WriteLine($"{volume:F2}");
        }

        private static void GetFaceDiagonals(double value)
        {
            double face = Math.Sqrt(2 * Math.Pow(value, 2));
            Console.WriteLine($"{face:F2}");
        }
    }
}
