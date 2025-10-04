using System;

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
