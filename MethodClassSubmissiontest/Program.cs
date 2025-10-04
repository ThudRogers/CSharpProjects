using System;

class Program
{
    static void Main()
    {
        // Instantiate the class
        MathAction mathAction = new MathAction();

        // Call method using positional parameters
        Console.WriteLine("Calling DoMath with positional arguments:");
        mathAction.DoMath(10, 25);

        // Call method using named parameters
        Console.WriteLine("\nCalling DoMath with named parameters:");
        mathAction.DoMath(number2: 40, number1: 15);

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}
public class MathAction
{
    // Void method that takes two integers as parameters
    public void DoMath(int number1, int number2)
    {
        // Do a math operation on the first integer
        int result = number1 + 50; // Example math operation (add 50 to the first number)

        // Display the results
        Console.WriteLine($"The result of the math operation on the first number ({number1}) is: {result}");
        Console.WriteLine($"The second number you entered is: {number2}");
    }
}
