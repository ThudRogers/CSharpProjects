using System;

class Program
{
    static void Main()
    {
        // Create instance of MathOperations
        MathOperations mathOps = new MathOperations();

        Console.WriteLine("Enter a number to perform math operations on:");
        string input = Console.ReadLine();

        try
        {
            int userNumber = Convert.ToInt32(input);

            // Call each method in turn
            int squared = mathOps.Square(userNumber);
            int doubled = mathOps.Double(userNumber);
            int plusTen = mathOps.AddTen(userNumber);

            // Display results
            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Square of {userNumber} = {squared}");
            Console.WriteLine($"Double of {userNumber} = {doubled}");
            Console.WriteLine($"{userNumber} + 10 = {plusTen}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }

        Console.WriteLine("\nProgram finished. Press Enter to exit...");
        Console.ReadLine();
    }
}
