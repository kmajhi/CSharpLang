using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        // Taking input for the first number
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Taking input for the second number
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Taking input for the third number
        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Calculating the sum
        int sum = num1 + num2 + num3;

        // Printing the result
        Console.WriteLine($"The sum of {num1}, {num2}, and {num3} is: {sum}");
    }
}
