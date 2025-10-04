using System;

public class MathOverload
{
    // Method 1: Takes an integer, performs addition
    public int DoMath(int number)
    {
        return number + 10;
    }

    // Method 2: Takes a decimal, performs subtraction (returns int)
    public int DoMath(decimal number)
    {
        return (int)(number - 5);
    }

    // Method 3: Takes a string, converts to int if possible, performs multiplication
    public int DoMath(string numberString)
    {
        int num = Convert.ToInt32(numberString);
        return num * 3;
    }
}
