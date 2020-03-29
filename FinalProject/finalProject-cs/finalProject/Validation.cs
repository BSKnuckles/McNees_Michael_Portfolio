using System;
namespace finalProject
{
    public class Validation
    {
        public static string StringNotEmpty(string message)
        {
            string input = null;
            bool validChoice = false;
            while (validChoice == false)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(
                        $"    Error: This cannot be blank!");
                }
                else
                {
                    validChoice = true;
                }
            }

            return input;
        }

        public static int GetInt(string message = "Enter an integer: ")
        {
            string input = null;
            int validatedInt;
            Console.Write(message);
            input = Console.ReadLine();

            while (!(Int32.TryParse(input, out validatedInt)))
            {
                Console.Write($"\n    Invalid entry: {input}\n   Please enter a whole number: ");
                input = Console.ReadLine();
            }
            return validatedInt;
        }

        public static int GetInt(string message, int min, int max)
        {
            int validatedInt;
            Console.Write(message);
            string input = Console.ReadLine();
            while (!(int.TryParse(input, out validatedInt)) || validatedInt < min || validatedInt > max)
            {
                if (input == "")
                {
                    Console.Write(
                        $"Error: This cannot be blank.\n" +
                        $"{message}");
                }
                else
                {
                    Console.Write(
                        $"Error: Invalid choice - \"{input}\".\n" +
                        $"{message}");
                }
                input = Console.ReadLine();
            }
            return validatedInt;
        }

        public static decimal GetDecimal(string message = "Enter a number: ")
        {
            decimal validatedDecimal;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!(Decimal.TryParse(input, out validatedDecimal)));
            return validatedDecimal;
        }
    }
}
