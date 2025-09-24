using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("------------------------------");

            // Ask applicant's age
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask applicant about DUI
            Console.Write("Have you ever had a DUI? (true/false): ");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask applicant about speeding tickets
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Qualification rules:
            // Must be over 15, no DUI, no more than 3 tickets
            bool isQualified = (age > 15 && hasDUI == false && speedingTickets <= 3);

            // Print result
            Console.WriteLine();
            Console.WriteLine("Qualified for car insurance? " + isQualified);

            Console.ReadLine();
        }
    }
}