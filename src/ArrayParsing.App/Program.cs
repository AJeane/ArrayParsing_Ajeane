using System;

namespace ArrayParsingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter delimited values (e.g., 1,2a,4,3,5): ");
                string input = Console.ReadLine();

                Console.WriteLine("Enter the delimiter: ");
                char delimiter = char.Parse(Console.ReadLine());

                // Process the input and display the validated result
                string result = ArrayProcessor.ProcessInput(input, delimiter);
                Console.WriteLine("Output: " + result);

                Console.WriteLine("Do you want to process another input? (yes/no)");
                string repeat = Console.ReadLine().ToLower();
                if (repeat != "yes")
                    break;
            }
        }
    }
}

