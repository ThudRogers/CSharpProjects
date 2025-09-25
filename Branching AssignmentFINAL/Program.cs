using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask for weight
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check weight limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program
            }

            // Ask for dimensions
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check dimension total
            int dimensionTotal = width + height + length;
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program
            }

            // Calculate quote
            decimal quote = (width * height * length * weight) / 100m;

            // Display result
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            Console.ReadLine(); // Keep console open
        }
    }
}
