using System;

class Program
{
    static void Main()
    {
        // Create an instance of the MathOverload class
        MathOverload mathOps = new MathOverload();

        // Integer version
        int result1 = mathOps.DoMath(10);
        Console.WriteLine($"Integer method result: {result1}");

        // Decimal version
        int result2 = mathOps.DoMath(15.5m);
        Console.WriteLine($"Decimal method result: {result2}");

        // String version
        int result3 = mathOps.DoMath("7");
        Console.WriteLine($"String method result: {result3}");

        Console.WriteLine("\nProgram finished. Press Enter to exit...");
        Console.ReadLine();
    }
}