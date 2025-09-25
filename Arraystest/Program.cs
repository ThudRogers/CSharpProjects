using System;
using System.Collections.Generic;

namespace ArrayAndListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. One-dimensional array of strings
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple" };
            Console.WriteLine("Choose an index of the colors array (0 - 4):");
            string input1 = Console.ReadLine();

            if (int.TryParse(input1, out int index1) && index1 >= 0 && index1 < colors.Length)
            {
                Console.WriteLine("You selected: " + colors[index1]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the colors array.");
            }

            Console.WriteLine();

            // 2. One-dimensional array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Choose an index of the numbers array (0 - 4):");
            string input2 = Console.ReadLine();

            if (int.TryParse(input2, out int index2) && index2 >= 0 && index2 < numbers.Length)
            {
                Console.WriteLine("You selected: " + numbers[index2]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the numbers array.");
            }

            Console.WriteLine();

            // 3. List of strings
            List<string> animals = new List<string>() { "Dog", "Cat", "Bird", "Fish", "Horse" };
            Console.WriteLine("Choose an index of the animals list (0 - 4):");
            string input3 = Console.ReadLine();

            if (int.TryParse(input3, out int index3) && index3 >= 0 && index3 < animals.Count)
            {
                Console.WriteLine("You selected: " + animals[index3]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the animals list.");
            }

            Console.WriteLine("\nProgram finished. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
