using System;

namespace McNees_Michael_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Michael McNees
             * September 15, 2019
             * SDI - Arrays
             */

            // Problem #1
            // Book Buyer

            // Create needed variables
            int numBooks = 0;
            decimal booksTotal = 0;

            // Clear the console and introduce the program
            Console.Clear();
            Console.WriteLine("Book Buyer Calculator\n");

            // Ask the user how many books they want and store this in a string variable
            Console.WriteLine("How many books would you like to purchase?");
            string sBooks = Console.ReadLine();

            // Validate the input from the user and re-prompt until a valid number is given
            while (!(int.TryParse(sBooks, out numBooks)) || numBooks < 1)
            {
                // Tell the user the problem
                Console.WriteLine("\nPlease enter a valid number of books.\nIt must be greater than 0 and not wirtten in letters.:");

                // Catch the response
                sBooks = Console.ReadLine();
            }

            // Create the array with the newly found 
            decimal[] books = new decimal[numBooks];

            // Cycle through the array to collect prices for each item
            for ( int i = 0; i < numBooks; i++)
            {
                // Reset the header
                Console.Clear();
                Console.WriteLine("Book Buyer Calculator\n");

                // Prompt for the book cost of the current item. +1 to make sure we start at 1 and not 0 for the user prompt.
                Console.WriteLine("What is the cost of book #{0}", i+1);
                string sBookCost = Console.ReadLine();

                // Validate the input
                while (!(decimal.TryParse(sBookCost, out books[i])))
                {
                    // Tell the user the problem
                    Console.WriteLine("\nPlease enter a valid price for this book:\n");

                    // Catch the response
                    sBookCost = Console.ReadLine();
                }
            }
            // Cycle through the array to calculate the total price of all books
            for (int j = 0; j < numBooks; j++)
            {
                booksTotal += books[j];
            }

            // Reset the header
            Console.Clear();
            Console.WriteLine("Book Buyer Calculator\n");

            // Output total cost
            Console.WriteLine("Your total for {0} book(s) is ${1}", numBooks, booksTotal);

            /*
             *  Test Results
             *
             *  Test #1
             *
             *  3 books
             *  Book 1 = 5.50
             *  Book 2 = 10.25
             *  Book 3 = 17.00
             *
             *  Result
             *  Your total for 3 book(s) is $32.75
             *
             *  Test #2
             *
             *  4 books
             *  Book 1 = 9.99
             *  Book 2 = 24.34
             *  Book 3 = 12
             *  Book 4 = 25
             *
             *  Result
             *  Your total for 4 book(s) is $71.33
             *
             *  Test #3
             *
             *  2 books
             *  Book 1 = three
             *      Please enter a valid price for this book:
             *
             *  Book 1 = 3.00
             *  Book 2 = 12.87
             *
             *  Result
             *  Your total for 2 book(s) is $15.87
             */

            // Prompt the user to continue to the next problem
            Console.WriteLine("\nPress any key to continue to the next problem:");
            Console.ReadLine();

            // Problem #2
            // Coloring Outside the Lines

            // Create the arrays
            string[] randomThings = new string[4];
            string[] colors = new string[4];

            string[] randomThingsTwo = new string[5];
            string[] colorsTwo = new string[5];

            // Fill the arrays
            randomThings[0] = "grapes";
            randomThings[1] = "apples";
            randomThings[2] = "limes";
            randomThings[3] = "lemons";

            colors[0] = "purple";
            colors[1] = "red";
            colors[2] = "green";
            colors[3] = "yellow";

            randomThingsTwo[0] = "ball";
            randomThingsTwo[1] = "carrot";
            randomThingsTwo[2] = "towel";
            randomThingsTwo[3] = "laptop";
            randomThingsTwo[4] = "stove";

            colorsTwo[0] = "red";
            colorsTwo[1] = "orange";
            colorsTwo[2] = "white";
            colorsTwo[3] = "silver";
            colorsTwo[4] = "black";

            // Add a heading for the first test
            Console.WriteLine("Arrays Test #1");

            // Cycle through the array and create a string for each entry
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("The main color of {0} is {1}", randomThings[i], colors[i]);
            }

            Console.WriteLine("\n");
            // Add a heading for the second test
            Console.WriteLine("Arrays Test #2");

            // Cycle through the array and create a string for each entry
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("The main color of {0} is {1}", randomThingsTwo[i], colorsTwo[i]);
            }
        }
    }
}
