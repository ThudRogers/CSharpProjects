using System;

class Program
{
    static void Main()
    {
        // Instantiate the class
        MathProcessor math = new MathProcessor();

        // Ask user for input
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        try
        {
            // Convert user input to integer
            int userNumber = Convert.ToInt32(input);

            // Call the first DivideByTwo method (direct output)
            math.DivideByTwo(userNumber);

            // Call the method with output parameter
            math.DivideByTwo(userNumber, out int result);
            Console.WriteLine($"(Using output parameter) Result: {result}");

            // Call the overloaded method (decimal version)
            math.DivideByTwo((decimal)userNumber);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}

public class MathProcessor
{
    // 1️⃣ Method that outputs an integer (divides data by 2)
    public void DivideByTwo(int number)
    {
        int result = number / 2;
        Console.WriteLine($"Your number divided by 2 is: {result}");
    }

    // 2️⃣ Method with output parameters
    public void DivideByTwo(int number, out int result)
    {
        result = number / 2;
    }

    // 3️⃣ Overloaded method (takes a decimal instead of int)
    public void DivideByTwo(decimal number)
    {
        decimal result = number / 2;
        Console.WriteLine($"(Overloaded method) Your decimal number divided by 2 is: {result}");
    }
}