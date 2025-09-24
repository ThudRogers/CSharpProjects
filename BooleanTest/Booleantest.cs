using System;

namespace BooleanLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Comparison with While and Do While Loops\n");

            // WHILE LOOP 
            Console.WriteLine("WHILE LOOP EXAMPLE:");
            int number = 1;

            // While loop runs while condition is true
            while (number <= 5)
            {
                Console.WriteLine($"Number is {number} (still <= 5)");
                number++;
            }
            Console.WriteLine("While loop ended because condition is now false.\n");

            //  DO WHILE LOOP
            Console.WriteLine("DO WHILE LOOP EXAMPLE:");
            int counter = 6;

            // Do...while loop runs at least once, even if condition is false
            do
            {
                Console.WriteLine($"Counter is {counter} (loop executes at least once)");
                counter++;
            }
            while (counter <= 5); // condition is false from the start

            Console.WriteLine("Do...while loop ended (but it executed once anyway).");

            Console.ReadLine(); // Keep console open
        }
    }
}