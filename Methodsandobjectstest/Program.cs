using System;

class Program
{
    static void Main()
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee()
        {
            FirstName = "Sample",
            LastName = "Student",
            Id = 1
        };

        // Call the superclass (Person) method SayName()
        employee.SayName();

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}

// Class Person with two string properties
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Void method that prints the full name
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

// Employee inherits from Person and adds an Id property
public class Employee : Person
{
    public int Id { get; set; }
}
