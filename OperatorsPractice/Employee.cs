using System;

namespace OperatorsPractice
{
    // The Employee class stores basic information about an employee
    public class Employee
    {
        // Property to store the employee's ID number
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the == operator so two Employee objects are compared by their Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both objects are null (empty), they are considered equal
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                return true;
            }

            // If only one of them is null, they cannot be equal
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // Otherwise, the employees are equal when their Id values match
            return employee1.Id == employee2.Id;
        }

        // Overload the != operator (comparison operators must be overloaded in pairs)
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // != is simply the opposite of ==, so reuse the == logic and flip the result
            return !(employee1 == employee2);
        }

        // Override Equals so it follows the same Id-based rule as the == operator
        public override bool Equals(object obj)
        {
            // Try to treat the object as an Employee (result is null if it isn't one)
            Employee other = obj as Employee;

            // Use the overloaded == operator to compare the two employees
            return this == other;
        }

        // Override GetHashCode to match Equals (equal employees must have the same hash code)
        public override int GetHashCode()
        {
            // The Id decides equality, so the Id's hash code is used here
            return Id.GetHashCode();
        }
    }
}
