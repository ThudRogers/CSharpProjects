using System;

class Program
{
    static void Main()
    {
        // Instantiate an Employee object
        Employee employee = new Employee()
        {
            firstName = "Sample",
            lastName = "Student"
        };

        // Call the implemented SayName() method
        employee.SayName();

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}

// Abstract base class Person
public abstract class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    // Abstract method (must be implemented by derived classes)
    public abstract void SayName();
}

// Derived class Employee inherits from Person
public class Employee : Person
{
    // Implementation of the abstract method
    public override void SayName()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
    }
}
