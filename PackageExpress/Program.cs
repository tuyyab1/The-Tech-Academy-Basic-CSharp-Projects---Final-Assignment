using System;

namespace PackageExpress
{
    class Program
    {
        // Main is the entry point: the program starts running here
        static void Main(string[] args)
        {
            // Display the required welcome message on the first line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            // Read what the user types and convert the text into a decimal number
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check whether the package is too heavy to ship
            if (weight > 50)
            {
                // Show the error message for an overweight package
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Wait for a key press so the console window doesn't close instantly
                Console.ReadLine();
                // Stop the program here
                return;
            }

            // Ask the user for the package width
            Console.WriteLine("Please enter the package width:");
            // Read the width and convert it to a decimal number
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user for the package height
            Console.WriteLine("Please enter the package height:");
            // Read the height and convert it to a decimal number
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user for the package length
            Console.WriteLine("Please enter the package length:");
            // Read the length and convert it to a decimal number
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Add the three dimensions together to get the total size
            decimal totalDimensions = width + height + length;

            // Check whether the combined dimensions are too big to ship
            if (totalDimensions > 50)
            {
                // Show the error message for an oversized package
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Wait for a key press so the console window doesn't close instantly
                Console.ReadLine();
                // Stop the program here
                return;
            }

            // Multiply height, width and length, then multiply by the weight,
            // and finally divide by 100 to get the shipping quote
            decimal quote = (height * width * length) * weight / 100;

            // Display the quote formatted as a dollar amount with two decimal places
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Display a closing message
            Console.WriteLine("Thank you!");

            // Wait for a key press so the console window stays open
            Console.ReadLine();
        }
    }
}
