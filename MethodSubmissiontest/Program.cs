using System;

class Program
{
    static void Main()
    {
        // Instantiate the class
        MathOptional mathOps = new MathOptional();

        Console.WriteLine("Enter your first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter your second number (or press Enter to skip):");
        string input2 = Console.ReadLine();

        try
        {
            int num1 = Convert.ToInt32(input1);

            int result;
            if (string.IsNullOrWhiteSpace(input2))
            {
                // Only one number entered, call with one parameter
                result = mathOps.DoMath(num1);
            }
            else
            {
                // Two numbers entered, call with both
                int num2 = Convert.ToInt32(input2);
                result = mathOps.DoMath(num1, num2);
            }

            Console.WriteLine($"\nThe result of your math operation is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Please enter valid integers.");
        }

        Console.WriteLine("\nProgram finished. Press Enter to exit...");
        Console.ReadLine();
    }
}
