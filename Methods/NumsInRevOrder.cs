using System;

public class NumbersInReversedOrder

{
    static void Main(string[] args)
    {
        string inputValue = Console.ReadLine();
        char[] inputToChar = inputValue.ToCharArray();
        Array.Reverse(inputToChar);
        string inputToString = new string(inputToChar);
        double stringToDouble = double.Parse(inputToString);
        Console.WriteLine(stringToDouble);
    }
}
