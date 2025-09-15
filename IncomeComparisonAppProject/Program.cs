using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Income Comparison Program!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            // Collects input for Person 1's hourly rate.
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();

            // Collects input for Person 1's hours worked per week.
            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek1 = Console.ReadLine();

            // Collects input for Person 2's hourly rate.
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();

            // Collects input for Person 2's hours worked per week.
            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek2 = Console.ReadLine();

            // Calculates annual salary for Person 1.
            int annualSalary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hoursPerWeek1) * 52;

            // Calculates annual salary for Person 2.
            int annualSalary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hoursPerWeek2) * 52;

            // Displays annual salary for Person 1.
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1);

            // Displays annual salary for Person 2.
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

            // Asks if Person 1 makes more money than Person 2.
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            // Compares the two annual salaries and stores the result.
            bool comparison = annualSalary1 > annualSalary2;

            // Displays the result of the comparison.
            Console.WriteLine(comparison);

            // Waits for the user to press Enter before exiting.
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
