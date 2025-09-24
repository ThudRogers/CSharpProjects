using System;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print headers
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("----------------------");

            // Ask for student name
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            // Ask what course student is on
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask page number (numeric input)
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if they need help (true/false input)
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask about positive experiences
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            // Ask for additional feedback
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Ask study hours (numeric input)
            Console.Write("How many hours did you study today? ");
            int studyHours = Convert.ToInt32(Console.ReadLine());

            // End of program message
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Optional: keep console open until user presses Enter
            Console.ReadLine();
        }
    }
}