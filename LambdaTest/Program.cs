using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of at least 10 employees
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Mary", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 4, FirstName = "Anna", LastName = "Davis" },
            new Employee { Id = 5, FirstName = "Michael", LastName = "Miller" },
            new Employee { Id = 6, FirstName = "Chris", LastName = "Wilson" },
            new Employee { Id = 7, FirstName = "Laura", LastName = "Moore" },
            new Employee { Id = 8, FirstName = "David", LastName = "Taylor" },
            new Employee { Id = 9, FirstName = "Sarah", LastName = "Anderson" },
            new Employee { Id = 10, FirstName = "Robert", LastName = "Thomas" }
        };

        // 1️⃣ Using foreach loop: list of all employees with the first name "Joe"
        List<Employee> joesForeach = new List<Employee>();
        foreach (Employee emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joesForeach.Add(emp);
            }
        }

        Console.WriteLine("Employees named Joe (using foreach loop):");
        foreach (Employee joe in joesForeach)
        {
            Console.WriteLine($" - {joe.FirstName} {joe.LastName} (Id: {joe.Id})");
        }

        // 2️⃣ Using lambda expression: list of all employees with the first name "Joe"
        List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

        Console.WriteLine("\nEmployees named Joe (using lambda expression):");
        foreach (Employee joe in joesLambda)
        {
            Console.WriteLine($" - {joe.FirstName} {joe.LastName} (Id: {joe.Id})");
        }

        // 3️⃣ Using lambda expression: list of employees with Id > 5
        List<Employee> highIdEmployees = employees.Where(emp => emp.Id > 5).ToList();

        Console.WriteLine("\nEmployees with Id greater than 5 (using lambda expression):");
        foreach (Employee emp in highIdEmployees)
        {
            Console.WriteLine($" - {emp.FirstName} {emp.LastName} (Id: {emp.Id})");
        }

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}

// Simple Employee class
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
