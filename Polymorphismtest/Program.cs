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

        // Use polymorphism: create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit() method through the interface
        quittableEmployee.Quit();

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

// Interface defining a Quit() method
public interface IQuittable
{
    void Quit();
}

// Derived class Employee inherits from Person and implements IQuittable
public class Employee : Person, IQuittable
{
    // Implementation of SayName() from Person
    public override void SayName()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
    }

    // Implementation of Quit() from IQuittable
    public void Quit()
    {
        Console.WriteLine($"{firstName} {lastName} has quit the job. Wishing them the best!");
    }
}
