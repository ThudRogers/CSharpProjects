using System;

class Program
{
    static void Main()
    {
        // Instantiate a Dog object
        Dog dog = new Dog()
        {
            Species = "Canine",
            Name = "Buddy"
        };

        // Call the implemented Describe() method
        dog.Describe();

        Console.WriteLine("\nProgram complete. Press Enter to exit...");
        Console.ReadLine();
    }
}

// Abstract base class Animal
public abstract class Animal
{
    public string Species { get; set; }
    public string Name { get; set; }

    // Abstract method (must be implemented by subclasses)
    public abstract void Describe();
}

// Derived class Dog inherits from Animal
public class Dog : Animal
{
    // Implementation of the abstract method
    public override void Describe()
    {
        Console.WriteLine($"This animal is a {Species} named {Name}.");
    }
}
