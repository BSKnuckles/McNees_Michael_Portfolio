using System;

namespace McNees_Michael_ShirtSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Michael McNees
             * September 22, 2019
             * SDI - Shirt Sizes Project
             */

            // Greet the user and explain what the program will do
            Console.WriteLine("Welcome to the Shirt Order calculator.\nThis app will determine the number of\nshirts you need to buy in each size available.\n");

            // Declare the test arrays outlined in the instructions

            // First test array
            string[] shirtOrder = {"Medium", "Small", "X-Large", "Small", "Large", "Medium", "Small", "X-Large", "XX-Large"};

            // Second test array
            // string[] shirtOrder = {"XX-Large", "Medium", "Large", "Small", "X-Large", "Small", "Large", "XX-Large", "Large", "XX-Large", "Medium", "Medium"};

            // Declare variables to hold the counts for each size and set them to 0 to begin counting in the main loop
            int small = 0;
            int medium = 0;
            int large = 0;
            int xlarge = 0;
            int xxlarge = 0;

            for (int i = 0; i < shirtOrder.Length; i++)
            {
                // Get the name of the current size to decide which variable to add it to
                string size = shirtOrder[i];

                // Check the array entry against the possible sizes and add it to the corresponding size variable
                if (size == "Small")
                {
                    small++;
                }
                else if (size == "Medium")
                {
                    medium++;
                }
                else if (size == "Large")
                {
                    large++;
                }
                else if (size == "X-Large")
                {
                    xlarge++;
                }
                else if (size == "XX-Large")
                {
                    xxlarge++;
                }
                else
                {
                    // Add this check just in case
                    // Helped catch one data entry error in array #2
                    Console.WriteLine("Some error occurred. It's probably Mike's fault.");
                }
            }

            // Write out the number of each size to order
            Console.WriteLine("Order {0} Small shirts", small);
            Console.WriteLine("Order {0} Medium shirts", medium);
            Console.WriteLine("Order {0} Large shirts", large);
            Console.WriteLine("Order {0} X-Large shirts", xlarge);
            Console.WriteLine("Order {0} XX-Large shirts", xxlarge);
        }
    }
}
