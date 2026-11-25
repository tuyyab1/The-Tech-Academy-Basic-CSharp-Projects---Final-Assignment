using System;

namespace ClassMethodPractice
{
    // This class holds the method we will call from Main()
    public class MathHelper
    {
        // A void method (returns nothing) that takes two integers as parameters
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Math operation on the first integer: multiply it by 5
            int result = firstNumber * 5;

            // Display the result of the math operation on the first integer
            Console.WriteLine("The first number multiplied by 5 is: " + result);

            // Display the second integer to the screen
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    class Program
    {
        // Main is the entry point: the program starts running here
        static void Main(string[] args)
        {
            // Instantiate (create an object of) the MathHelper class
            MathHelper helper = new MathHelper();

            // Call the method, passing in two numbers in the normal order
            Console.WriteLine("Calling the method with positional parameters:");
            helper.DoMath(10, 20);

            // Call the method again, specifying the parameters by name
            // Naming them lets us list them in any order
            Console.WriteLine("Calling the method with named parameters:");
            helper.DoMath(secondNumber: 50, firstNumber: 8);

            // Wait for a key press so the console window stays open
            Console.ReadLine();
        }
    }
}
