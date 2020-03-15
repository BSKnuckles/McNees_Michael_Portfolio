using System;

namespace McNees_Michael_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Michael McNees
             * September 22, 2019
             * SDI - Functions Excercise
             */

            // ~~~~~~~~~~~~~~~~~~~~~~~~
            // ~~~~~ Problem #1 ~~~~~~~
            // ~~ Currency Converter ~~
            // ~~~~~~~~~~~~~~~~~~~~~~~~

            // Build the header
            BuildHeader("Euro to USD Converter", "Welcome");

            // Ask the user for an input to convert
            Console.WriteLine("Please enter an amount in EUR to convert to USD:");
            string inputString = Console.ReadLine();

            // Declare a variable to hold the converted value
            decimal euro;

            // Validate the user is typing in a valid number using a while loop.
            while (!decimal.TryParse(inputString, out euro))
            {
                // Rebuild the header
                BuildHeader("Euro to USD Converter", "Try Again");
                // Reprompt the user and tell them what's wrong
                Console.WriteLine("Please only type in numbers and do not leave blank.\nPlease enter an amount in EUR to convert to USD:");

                // Re-collect the variable for another parse atempt
                inputString = Console.ReadLine();

            }

            //Rebuild the header
            BuildHeader("Euro to USD Converter", "Results");

            // Send the value to the method for conversion
            decimal converted = Math.Round(ConvertEuroUsDollar(euro), 2);
            Console.WriteLine("€{0} converted to USD is ${1}", euro, converted);

            /*
             * Test Results
             *
             * Test #1
             * Input = 5.50
             * Output = "€5.50 converted to USD is $6.38"
             *
             * Test #2
             * Input = 15.32
             * Output = "€15.32 converted to USD is $17.77"
             *
             * Test #3
             * Input = 2653.45
             * Output = "€2653.45 converted to USD is $3078.00"
             */

            Console.WriteLine("\n\nPress any key to move to the next problem:");
            Console.ReadLine();


            // ~~~~~~~~~~~~~~~~~~~~~~~~
            // ~~~~~ Problem #2 ~~~~~~~
            // ~~~~~ Astronomical ~~~~~
            // ~~~~~~~~~~~~~~~~~~~~~~~~

            // Build the header
            BuildHeader("Astronomical Weight Converter", "Welcome");

            // Ask the user for an input to convert
            Console.WriteLine("Please enter your weight on Earth:");
            string weightString = Console.ReadLine();

            // Declare a value to hold the converted value
            double weightOnEarth;

            while (!double.TryParse(weightString, out weightOnEarth))
            {
                // Rebuild the header
                BuildHeader("Astronomical Weight Converter", "Try Again");
                // Reprompt the user and tell them what's wrong
                Console.WriteLine("Please only type in numbers and do not leave blank.\nPlease enter your weight on Earth:");

                // Re-collect the variable for another parse atempt
                weightString = Console.ReadLine();
            }

            // Rebuild the header for step 2
            BuildHeader("Astronomical Weight Converter", "Planet Choice");

            // Ask the user to choose which planet to convert their weight for
            Console.WriteLine("Please enter the number of the planet you wish to convert your weight to:\n1: Mercury\n2: Venus\n3: Earth\n4: Mars\n5: Jupiter\n6: Saturn\n7: Uranus\n8: Neptune");

            // Collect and validate the input integer is between 1 and 9
            string planetChoiceString = Console.ReadLine();
            int planetChoice;

            while (!int.TryParse(planetChoiceString, out planetChoice) || planetChoice <= 0 || planetChoice > 8)
            {
                // Rebuild the header
                BuildHeader("Astronomical Weight Converter", "Try Again");
                // Reprompt the user and tell them what's wrong
                Console.WriteLine("Please enter a number between 1 and 8 corresponding to your planet choice:\n1: Mercury\n2: Venus\n3: Earth\n4: Mars\n5: Jupiter\n6: Saturn\n7: Uranus\n8: Neptune");

                // Re-collect the variable for another parse atempt
                planetChoiceString = Console.ReadLine();
            }

            // Rebuild the header for the results
            BuildHeader("Astronomical Weight Converter", "Calculated Results");

            if (planetChoice == 1)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Mercury you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, .38));
            }
            else if (planetChoice == 2)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Venus you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, .91));
            }
            else if (planetChoice == 3)
            {
                Console.WriteLine("On Earth you weight {0} lbs, and on Earth you would still weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, 1));
            }
            else if (planetChoice == 4)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Mars you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, .38));
            }
            else if (planetChoice == 5)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Jupiter you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, 2.34));
            }
            else if (planetChoice == 6)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Saturn you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, .93));
            }
            else if (planetChoice == 7)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Uranus you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, .92));
            }
            else if (planetChoice == 8)
            {
                Console.WriteLine("On Earth you weight {0} lbs, but on Neptune you would weigh {1} lbs.", weightOnEarth, PlanetaryWeightConverter(weightOnEarth, 1.12));
            }
            else
            {
                Console.WriteLine("You did not enter a valid value.");
            }

            /*
             * Test Results
             *
             * Test #1
             * Input 1 = 160
             * Input 2 = 6
             *
             * Results = "On Earth you weight 160 lbs, but on Saturn you would weigh 148.8 lbs."
             *
             * Test #2
             * Input 1 = 210
             * Input 2 = -9
             * Re-Prompted
             * "Try Again"
             *
             * "Please enter a number between 1 and 8 corresponding to your planet choice:"
             * Input 3 = 5
             * 
             * Results = "On Earth you weight 210 lbs, but on Jupiter you would weigh 491.4 lbs."
             *
             * Test #3
             * Input 1 = 250
             * Input 2 = 8
             *
             * Results = "On Earth you weight 250 lbs, but on Neptune you would weigh 280 lbs."
             */

            Console.WriteLine("\n\nPress any key to move to the next problem:");
            Console.ReadLine();

            // ~~~~~~~~~~~~~~~~~~~~~~~~
            // ~~~~~ Problem #3 ~~~~~~~
            // ~~ Dramatic Discounts ~~
            // ~~~~~~~~~~~~~~~~~~~~~~~~

            // Create a new array to hold the discount rates and fill in those rates
            decimal[] discounts = new decimal[6];
            discounts[0] = 5;
            discounts[1] = 10;
            discounts[2] = 15;
            discounts[3] = 20;
            discounts[4] = 25;
            discounts[5] = 30;

            // Introduce the app
            BuildHeader("Discount Calculator", "Welcome");

            // Ask for the price of an item and validate the entry is a number
            Console.WriteLine("Please enter the price of an item:");
            string itemPriceString = Console.ReadLine();

            // Declare a variable to hold the converted value
            decimal itemPrice;

            // Validate the user is typing in a valid number using a while loop.
            while (!decimal.TryParse(itemPriceString, out itemPrice))
            {
                // Rebuild the header
                BuildHeader("Discount Calculator", "Try Again");
                // Reprompt the user and tell them what's wrong
                Console.WriteLine("The price should contain numbers only.\nPlease enter the price of an item:");

                // Re-collect the variable for another parse atempt
                itemPriceString = Console.ReadLine();

            }

            // Rebuild the header
            BuildHeader("Discount Calculator", "Calculated Discounts");

            for (int i = 0; i < discounts.Length; i++)
            {
                decimal discountedPrice = DiscountCalc(itemPrice, discounts[i]);
                Console.WriteLine("${0} with a {1}% discount is ${2}.", itemPrice.ToString("0.00"), discounts[i], discountedPrice.ToString("0.00"));
            }

            /*
             * Test Results
             *
             * Test #1
             * Input = 10
             *
             * Results:
             * $10.00 with a 5% discount is $9.50.
             * $10.00 with a 10% discount is $9.00.
             * $10.00 with a 15% discount is $8.50.
             * $10.00 with a 20% discount is $8.00.
             * $10.00 with a 25% discount is $7.50.
             * $10.00 with a 30% discount is $7.00.
             *
             * Test #2
             * Input = 17.99
             *
             * Results:
             * $17.99 with a 5% discount is $17.09.
             * $17.99 with a 10% discount is $16.19.
             * $17.99 with a 15% discount is $15.29.
             * $17.99 with a 20% discount is $14.39.
             * $17.99 with a 25% discount is $13.49.
             * $17.99 with a 30% discount is $12.59.
             *
             * Test #3
             * Input = 126.35
             *
             * Results:
             * $126.35 with a 5% discount is $120.03.
             * $126.35 with a 10% discount is $113.72.
             * $126.35 with a 15% discount is $107.40.
             * $126.35 with a 20% discount is $101.08.
             * $126.35 with a 25% discount is $94.76.
             * $126.35 with a 30% discount is $88.44.
             */

        }

        public static void BuildHeader(string appName, string subHeading)
        {
            // Clear the console and create a header containing the name of the app and the current stage
            Console.Clear();
            Console.WriteLine("{0}\n---------------------\n{1}\n", appName, subHeading);
        }

        public static decimal ConvertEuroUsDollar (decimal input)
        {
            decimal calculatedValue = input * 1.16M;
            return calculatedValue;
        }

        public static double PlanetaryWeightConverter (double weightInput, double conversionRate)
        {
            double convertedWeight = weightInput * conversionRate;
            return convertedWeight;
        }

        public static decimal DiscountCalc (decimal price, decimal discount)
        {
            decimal finalPrice = Math.Round(price - (price * (discount / 100)), 2);
            return finalPrice;
        }
    }
}
