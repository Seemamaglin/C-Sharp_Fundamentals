using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int number);

        if (!isValid || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer greater than 0.");
            return;
        }

        long result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is {result}");
    }

    static long Factorial(int n)
    {
        long fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }
}