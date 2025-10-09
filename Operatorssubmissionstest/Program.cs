using System;

class Program
{
    static void Main()
    {
        // Create two Employee objects
        Employee emp1 = new Employee()
        {
            firstName = "Sample",
            lastName = "Student",
            Id = 1
        };

        Employee emp2 = new Employee()
        {
            firstName = "Example",
            lastName = "Worker",
            Id = 1
        };

        Employee emp3 = new Employee()
        {
            firstName = "Other",
            lastName = "Person",
            Id = 2
        };

        // Compare using overloaded == operator
        Console.WriteLine("Comparing emp1 and emp2:");
        Console.WriteLine(emp1 == emp2 ? "They are equal (same Id)." : "They are NOT equal.");

        Console.WriteLine("\nComparing emp1 and emp3:");
        Console.WriteLine(emp1 == emp3 ? "They are equal (same Id)." : "They are NOT equal.");

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
    public int Id { get; set; }

    // Implementation of SayName()
    public override void SayName()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
    }

    // Overload the == operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Handle null checks to prevent exceptions
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        return emp1.Id == emp2.Id;
    }

    // Overload the != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals() and GetHashCode() to match operator behavior
    public override bool Equals(object obj)
    {
        if (obj is Employee other)
        {
            return this.Id == other.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
