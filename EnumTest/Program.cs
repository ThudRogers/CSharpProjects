using System;

class Program
{
    // Enum representing the days of the week
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void Main()
    {
        try
        {
            // Prompt user for input
            Console.WriteLine("Please enter the current day of the week:");
            string userInput = Console.ReadLine();

            // Convert input to enum type (case-insensitive)
            DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

            // Display the parsed enum value
            Console.WriteLine($"You entered: {currentDay}");
        }
        catch (Exception)
        {
            // Handle invalid input gracefully
            Console.WriteLine("Please enter an actual day of the week.");
        }

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}
