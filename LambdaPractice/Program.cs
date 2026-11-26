using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaPractice
{
    class Program
    {
        // Main is the entry point: the program starts running here
        static void Main(string[] args)
        {
            // Step 2: Create a list of 12 employees (three of them are named "Joe")
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1,  FirstName = "Joe",    LastName = "Smith" },
                new Employee() { Id = 2,  FirstName = "Maria",  LastName = "Garcia" },
                new Employee() { Id = 3,  FirstName = "Joe",    LastName = "Brown" },
                new Employee() { Id = 4,  FirstName = "Priya",  LastName = "Patel" },
                new Employee() { Id = 5,  FirstName = "Liam",   LastName = "Wilson" },
                new Employee() { Id = 6,  FirstName = "Sofia",  LastName = "Lopez" },
                new Employee() { Id = 7,  FirstName = "Joe",    LastName = "Taylor" },
                new Employee() { Id = 8,  FirstName = "Chen",   LastName = "Wang" },
                new Employee() { Id = 9,  FirstName = "Amara",  LastName = "Okafor" },
                new Employee() { Id = 10, FirstName = "Noah",   LastName = "Martin" },
                new Employee() { Id = 11, FirstName = "Emma",   LastName = "Davis" },
                new Employee() { Id = 12, FirstName = "Lucas",  LastName = "Moore" }
            };

            // Step 3: Use a foreach loop to build a new list of employees named "Joe"
            // Create an empty list to hold the matching employees
            List<Employee> joesForeach = new List<Employee>();

            // Loop through every employee in the main list
            foreach (Employee employee in employees)
            {
                // Check the FirstName property of the current employee
                if (employee.FirstName == "Joe")
                {
                    // Add the matching employee to the new list
                    joesForeach.Add(employee);
                }
            }

            // Display a heading for the foreach results
            Console.WriteLine("Employees named Joe (foreach loop):");

            // Loop through the new list and print each employee's details
            foreach (Employee employee in joesForeach)
            {
                Console.WriteLine("Id: " + employee.Id + " - " + employee.FirstName + " " + employee.LastName);
            }

            // Step 4: Do the same thing with a lambda expression
            // Where() keeps only the employees for which the lambda returns true
            // "e => e.FirstName == "Joe"" reads as: for each employee e, check if e's FirstName is "Joe"
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Display a blank line and a heading for the lambda results
            Console.WriteLine();
            Console.WriteLine("Employees named Joe (lambda expression):");

            // Loop through the lambda result list and print each employee's details
            foreach (Employee employee in joesLambda)
            {
                Console.WriteLine("Id: " + employee.Id + " - " + employee.FirstName + " " + employee.LastName);
            }

            // Step 5: Use a lambda expression to make a list of employees with an Id greater than 5
            // The lambda keeps each employee e where e.Id is greater than 5
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Display a blank line and a heading for the Id results
            Console.WriteLine();
            Console.WriteLine("Employees with an Id greater than 5 (lambda expression):");

            // Loop through the Id result list and print each employee's details
            foreach (Employee employee in idGreaterThanFive)
            {
                Console.WriteLine("Id: " + employee.Id + " - " + employee.FirstName + " " + employee.LastName);
            }

            // Wait for a key press so the console window stays open
            Console.ReadLine();
        }
    }
}
