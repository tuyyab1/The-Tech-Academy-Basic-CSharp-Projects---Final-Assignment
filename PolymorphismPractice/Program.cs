using System;

namespace PolymorphismPractice
{
    // Step 1: An interface that defines a void method called Quit()
    // An interface only declares the method; classes that use it provide the code
    public interface IQuittable
    {
        // Declare the Quit method (no body, no return value)
        void Quit();
    }

    // Step 2: The Employee class inherits (implements) the IQuittable interface
    // The colon (:) shows that Employee uses the IQuittable interface
    public class Employee : IQuittable
    {
        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Property to store the employee's ID number
        public int Id { get; set; }

        // Method that displays the employee's full name
        public void SayName()
        {
            // Print the first and last name together
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implement the Quit() method required by the IQuittable interface
        public void Quit()
        {
            // Display a message showing that this employee has quit
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }

    class Program
    {
        // Main is the entry point: the program starts running here
        static void Main(string[] args)
        {
            // Step 3: Polymorphism - create a variable of the interface type
            // and assign it an Employee object (allowed because Employee implements IQuittable)
            IQuittable quittableEmployee = new Employee()
            {
                // Set the employee's first name
                FirstName = "Sample",
                // Set the employee's last name
                LastName = "Employee",
                // Set the employee's ID number
                Id = 1
            };

            // Call the Quit() method through the interface type
            quittableEmployee.Quit();

            // Wait for a key press so the console window stays open
            Console.ReadLine();
        }
    }
}
