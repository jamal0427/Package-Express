using System;

class Program
{
    static void Main()
    {
        // Step 1: Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Step 2: Get package weight
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Step 3: Check if too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Step 4: Get package width
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // Step 5: Get package height
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Step 6: Get package length
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Step 7: Check if too big
        int totalDimensions = width + height + length;

        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Step 8: Calculate quote
        double quote = (width * height * length * weight) / 100.0;

        // Step 9 & 10: Display result
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");

        Console.ReadLine();
    }
}
