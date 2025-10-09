using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Instantiate an Employee object with string type parameter
        Employee<string> stringEmployee = new Employee<string>()
        {
            firstName = "John",
            lastName = "Doe",
            Id = 1,
            Things = new List<string> { "Laptop", "Notebook", "Pen", "Headphones" }
        };

        // Instantiate an Employee object with int type parameter
        Employee<int> intEmployee = new Employee<int>()
        {
            firstName = "Jane",
            lastName = "Smith",
            Id = 2,
            Things = new List<int> { 10, 20, 30, 40, 50 }
        };

        // Print stringEmployee's Things
        Console.WriteLine($"Employee: {stringEmployee.firstName} {stringEmployee.lastName} (String Things)");
        foreach (string thing in stringEmployee.Things)
        {
            Console.WriteLine($" - {thing}");
        }

        Console.WriteLine();

        // Print intEmployee's Things
        Console.WriteLine($"Employee: {intEmployee.firstName} {intEmployee.lastName} (Int Things)");
        foreach (int thing in intEmployee.Things)
        {
            Console.WriteLine($" - {thing}");
        }

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}

// Base abstract class Person
public abstract class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public abstract void SayName();
}

// Generic Employee class inheriting from Person
public class Employee<T> : Person
{
    public int Id { get; set; }

    // Generic list property
    public List<T> Things { get; set; }

    // Implementation of SayName()
    public override void SayName()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
    }
}
