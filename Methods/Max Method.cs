using System;

namespace Methods
{
    class Max_Method
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxOfFirstTwo = GetMax(firstNumber, secondNumber);

            if (maxOfFirstTwo >= thirdNumber)
            {
                Console.WriteLine(maxOfFirstTwo);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int bigger = 0;
            if (firstNumber >= secondNumber)
            {
                bigger = firstNumber;
            }
            else
            {
                bigger = secondNumber;
            }
            return bigger;
        }
    }
}