using System;

namespace OperatorsPractice
{
    class Program
    {
        // Main is the entry point: the program starts running here
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties
            Employee employee1 = new Employee();
            employee1.Id = 101;
            employee1.FirstName = "Sam";
            employee1.LastName = "Taylor";

            // Instantiate the second Employee object and assign values to its properties
            // It has the same Id as employee1 but a different name
            Employee employee2 = new Employee();
            employee2.Id = 101;
            employee2.FirstName = "Alex";
            employee2.LastName = "Morgan";

            // Compare the two employees using the overloaded == operator and display the result
            Console.WriteLine("Are the employees equal (==)? " + (employee1 == employee2));

            // Compare the two employees using the overloaded != operator and display the result
            Console.WriteLine("Are the employees not equal (!=)? " + (employee1 != employee2));

            // Change the second employee's Id so it no longer matches the first
            employee2.Id = 202;

            // Compare again with == after the Id change and display the result
            Console.WriteLine("After changing the Id, are they equal (==)? " + (employee1 == employee2));

            // Compare again with != after the Id change and display the result
            Console.WriteLine("After changing the Id, are they not equal (!=)? " + (employee1 != employee2));

            // Wait for a key press so the console window stays open
            Console.ReadLine();
        }
    }
}
