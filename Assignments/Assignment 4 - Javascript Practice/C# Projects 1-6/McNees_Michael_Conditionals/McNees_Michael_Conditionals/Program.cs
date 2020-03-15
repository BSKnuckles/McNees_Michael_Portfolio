using System;

namespace McNees_Michael_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*
             * Michael McNees
             * September 15, 2019
             * SDI - Conditionals Assignment
             */


            /*
             * Problem #0 "Example" -_-
             * I realized this was an example AFTER completing it.
             * 
             * Stuff Your Face
             */

            // Introduce the problem
            Console.WriteLine("Example Problem\n\nStrawberry Festival Pie Eating Contest\nHeavyweight Division Weight Checker\n\nPlease enter the competitor's weight:");

            // Collect and convert the competitor's weight to an int for later operations
            string initialWeight = Console.ReadLine();
            Int32.TryParse(initialWeight, out int weight);

            // Determine if the competitor is above 250 lbs or below
            if (weight >= 250)
            {
                Console.WriteLine("\nThe competitor qualifies for the heavyweight division.");
            }
            // Alert the user for values less than 250 lbs but greater than 0 lbs
            else if (weight < 250 && weight > 0)
            {
                Console.WriteLine("\nThe competitor needs to gain some weight!");
                
            }
            // Alert the user for an invalid value. This also captures invalid entries, like "ten"
            else if (weight == 0)
            {
                Console.WriteLine("You entered an invalid value.");
            }

            // Prompt the user to continue to the next problem
            Console.WriteLine("\nPress any key to continue to Problem #1.");
            Console.ReadLine();
            Console.Clear();

            /*
             * Problem #1
             * Free Shipping
             */

            // Introduce the problem
            Console.WriteLine("Problem #1\n\nFree Shipping Grocery Calculator\n\nHow many items are you buying?");

            // Collect and convert the number of items to an int for later operations
            string initialItems = Console.ReadLine();
            decimal.TryParse(initialItems, out decimal items);
            decimal itemShip = 1.25M;
            decimal shipping = items * itemShip;

            // Calculate shipping for less than 5 items
            if (items < 5 && items > 0)
            {
                Console.WriteLine("Your cost for shipping today for {0} items is ${1}.", items, shipping);
            }
            // Alert the user they get free shipping
            else if (items >= 5)
            {
                Console.WriteLine("Congratulations! You have bought {0} items, so you qualify for free shipping!", items);
            }
            // Warn the user about an invalid entry
            else
            {
                Console.WriteLine("You entered an invalid value.");
            }

            // Prompt the user to continue to the next problem
            Console.WriteLine("\nPress any key to continue to Problem #2.");
            Console.ReadLine();
            Console.Clear();

            /*
             * Test Results
             *
             * 2 items  = Your cost for shipping today for 2 items is $2.50
             * 4 items  = Your cost for shipping today for 4 items is $5.00
             * 5 items  = Congratulations! You have bought 5 items, so you qualify for free shipping!
             * 7 items  = Congratulations! You have bought 7 items, so you qualify for free shipping!
             * 20 items = Congratulations! You have bought 20 items, so you qualify for free shipping!
             * 
             */



            /*
             * Problem #2
             * Mall Employee DIscount
             */

            decimal discount = .9M;

            // Introduce the problem
            Console.WriteLine("Problem #2\n\nMall Employee Discount Calculator");

            // Collect the cost of the first item
            Console.WriteLine("\nWhat is the cost of your first item?");
            string initialItemOneCost = Console.ReadLine();
            decimal.TryParse(initialItemOneCost, out decimal itemOneCost);

            // Collect the cost of the second item
            Console.WriteLine("\nWhat is the cost of your second item?");
            string initialItemTwoCost = Console.ReadLine();
            decimal.TryParse(initialItemTwoCost, out decimal itemTwoCost);

            // Find out if the user is a mall employee
            Console.WriteLine("Are you an employee of the mall?");
            string employee = Console.ReadLine();

            // Evaluate whether the employee is an employee and then calculate their total depending on the result.
            if (employee.ToUpper() == "NO" && itemOneCost != 0 && itemTwoCost != 0)
            {
                // Calculate the total for a non-mall employee
                decimal nonEmployeeCost = Math.Round(itemOneCost + itemTwoCost, 2);
                Console.WriteLine("Your total purchase is ${0}.", nonEmployeeCost);
            }
            else if (employee.ToUpper() == "YES" && itemOneCost != 0 && itemTwoCost != 0)
            {
                // Calculate the total for a mall employee, rounded to 2 decimal places
                decimal employeeCost = itemOneCost + itemTwoCost;
                decimal discountedCost = Math.Round((itemOneCost + itemTwoCost) * discount, 2);
                Console.WriteLine("Your total purchase is ${0},\nbut with your 10% employee discount\nis now ${1}", employeeCost, discountedCost);
            }
            else
            {
                Console.WriteLine("You entered an invalid value.");
            }

            // Prompt the user to continue to the next problem
            Console.WriteLine("\nPress any key to continue to Problem #3.");
            Console.ReadLine();
            Console.Clear();

            /*
             * Test Results
             *
             * Item 1 = 65.90   Item 2 = 85.00  Employee = yes
             *
             * Your total purchase is $150.90,
             * but with your 10% employee discount
             * is now $135.81 
             *
             * Item 1 = 19.99   Item 2 = 40.20  Employee = no
             *
             * Your total purchase is $60.19.
             *
             */



            /*
             * Problem #3
             * Apple Pickers
             */

            decimal costByWeight;
            decimal totalCost;

            // Introduce the problem
            Console.WriteLine("Problem #3\n\nYou-Pick Apple Bulk Cost Calculator");

            // Collect the weight of the apples picked
            Console.WriteLine("\nHow many pounds of apples have you collected?");
            string initialApplesWeight = Console.ReadLine();
            decimal.TryParse(initialApplesWeight, out decimal applesWeight);

            // Calculate the total cost for a weight of less than 7 lbs
            if (applesWeight < 7 && applesWeight > 0)
            {
                costByWeight = 1.00M;
                totalCost = Math.Round(applesWeight * costByWeight, 2);
                Console.WriteLine("Your basket of apples of {0} lbs. costs ${1}", applesWeight, totalCost);
            }

            // Calculate the total cost for a weight of less than 15.25 lbs but greater than 7
            else if (applesWeight >= 7 && applesWeight < 15.25M)
            {
                costByWeight = .90M;
                totalCost = Math.Round(applesWeight * costByWeight, 2);
                Console.WriteLine("Your basket of apples of {0} lbs. costs ${1}", applesWeight, totalCost);
            }

            // Calculate the total cost for a weight of less than 40 lbs but greater than 15.25
            else if (applesWeight >= 15.25M && applesWeight < 50)
            {
                costByWeight = .80M;
                totalCost = Math.Round(applesWeight * costByWeight, 2);
                Console.WriteLine("Your basket of apples of {0} lbs. costs ${1}", applesWeight, totalCost);
            }

            // Calculate the total cost for a weight of less than 70.5 lbs but greater than 40
            else if (applesWeight >= 40 && applesWeight < 70.5M)
            {
                costByWeight = .70M;
                totalCost = Math.Round(applesWeight * costByWeight, 2);
                Console.WriteLine("Your basket of apples of {0} lbs. costs ${1}", applesWeight, totalCost);
            }

            // Calculate the total cost for a weight of 100 lbs or less, but still greater than 70.5
            else if (applesWeight >= 70.5M && applesWeight <= 100)
            {
                costByWeight = .60M;
                totalCost = Math.Round(applesWeight * costByWeight, 2);
                Console.WriteLine("Your basket of apples of {0} lbs. costs ${1}", applesWeight, totalCost);
            }

            // Calculate the total cost for a weight of more than 100 lbs
            else if (applesWeight > 100)
            {
                costByWeight = .50M;
                totalCost = Math.Round(applesWeight * costByWeight, 2);
                Console.WriteLine("Your basket of apples of {0} lbs. costs ${1}", applesWeight, totalCost);
            }

            else
            {
                Console.WriteLine("You entered an invalid number.");
            }

            /* Test Results
             *
             * 4.5 lbs      = Your basket of apples of 4.5 lbs. costs $4.50
             * 10 lbs       = Your basket of apples of 10 lbs. costs $9.00
             * 15.25 lbs    = Your basket of apples of 15.25 lbs. costs $12.20
             * 30 lbs       = Your basket of apples of 30 lbs. costs $24.00
             * 60.50 lbs    = Your basket of apples of 60.50 lbs. costs $42.35
             * 100 lbs      = Your basket of apples of 100 lbs. costs $60.00
             * 150.30 lbs   = Your basket of apples of 150.30 lbs. costs $75.15
             *
             */

            // Prompt the user to continue to the next problem
            Console.WriteLine("\nPress any key to continue to Problem #4.");
            Console.ReadLine();
            Console.Clear();


            /*
             * Problem #4
             * Nerd OUt
             */

            decimal standardTicket = 55.00M;
            decimal discountedTicket = 40.00M;

            // Introduce the problem
            Console.WriteLine("Problem #4\n\nComic Con Ticket Price Calculator");

            // Collect the user's age
            Console.WriteLine("\nHow old are you?");
            string initialAge = Console.ReadLine();
            decimal.TryParse(initialAge, out decimal age);

            if ((age >= 65 || age < 7) && age > 0)
            {
                Console.WriteLine("Your cost for your ticket to Comic Con is ${0}", discountedTicket);
            }
            else
            {
                Console.WriteLine("Your cost for your ticket to Comic Con is ${0}", standardTicket);
            }

            /*
             * Test Results
             *
             * 68   = Your cost for your ticket to Comic Con is $40.00
             * 29   = Your cost for your ticket to Comic Con is $55.00
             * 6    = Your cost for your ticket to Comic Con is $40.00
             * 7    = Your cost for your ticket to Comic Con is $55.00
             * 100  = Your cost for your ticket to Comic Con is $40.00
             *
             */
        }
    }
}
