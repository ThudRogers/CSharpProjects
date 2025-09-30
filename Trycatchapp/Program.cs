using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        Console.WriteLine("Enter a number to divide each list item by:");
        string input = Console.ReadLine();

        try
        {
            // Convert user input to integer
            int divisor = Convert.ToInt32(input);

            Console.WriteLine("\nResults:");
            foreach (int num in numbers)
            {
                int result = num / divisor;
                Console.WriteLine($"{num} ÷ {divisor} = {result}");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("\nError: You cannot divide by zero.");
            Console.WriteLine("System message: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nError: That is not a valid number.");
            Console.WriteLine("System message: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Fallback for unexpected errors
            Console.WriteLine("\nAn unexpected error occurred.");
            Console.WriteLine("System message: " + ex.Message);
        }

        // This always runs
        Console.WriteLine("\nProgram has continued after the try/catch block.");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}