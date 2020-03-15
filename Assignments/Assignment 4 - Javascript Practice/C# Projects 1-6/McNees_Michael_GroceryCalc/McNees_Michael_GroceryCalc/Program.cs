using System;

namespace McNees_Michael_GroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Michael McNees
             * September 8th, 2019
             * SDI Grocery Calculator
             */

            // Introduce the app
            Console.WriteLine("\tMcNees Grocery Calculator");
            Console.WriteLine("--------------------------------------\n");

            // Collect the cost variables
            Console.WriteLine("Please provide the price\nfor the following items:");

            Console.WriteLine("\nA Banana:");
            string costBanana       =   Console.ReadLine();

            Console.WriteLine("\nA Beef Brisket:");
            string costBrisket      =   Console.ReadLine();

            Console.WriteLine("\nAn Apple Pie:");
            string costPie          =   Console.ReadLine();

            // Convert the costs to decimal data types
            decimal costBananaDec   =   Decimal.Parse(costBanana);
            decimal costBrisketDec  =   Decimal.Parse(costBrisket);
            decimal costPieDec      =   Decimal.Parse(costPie);

            // Clear the console and ask the user for the quantities of each item
            Console.Clear();
            Console.WriteLine("\tMcNees Grocery Calculator");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("How many of each item\ndo you wish to purchase?");

            // Collect the quantity variables and convert them. Using ints since you cannot buy a partial item.
            Console.WriteLine("\nBananas:");
            string qtyBanana = Console.ReadLine();
            int bananas = Int16.Parse(qtyBanana);

            Console.WriteLine("\nBeef Briskets:");
            string qtyBrisket = Console.ReadLine();
            int briskets = Int16.Parse(qtyBrisket);

            Console.WriteLine("\nApple Pies:");
            string qtyPie = Console.ReadLine();
            int pies = Int16.Parse(qtyPie);

            // Display the final quantities and prices of each item and sales tax for review
            Console.Clear();
            Console.WriteLine("\tMcNees Grocery Calculator");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Confirm your quantities\nand prices below:\n");
            Console.WriteLine("Qty\tItem\t\tPrice");
            Console.WriteLine(qtyBanana + "\tBanana(s)\t$" + costBananaDec);
            Console.WriteLine(qtyBrisket + "\tBrisket(s)\t$" + costBrisketDec);
            Console.WriteLine(qtyPie + "\tApple Pie(s)\t$" + costPieDec);
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();

            // Ask for the user's sales tax rate
            Console.Clear();
            Console.WriteLine("\tMcNees Grocery Calculator");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("What is the sales tax where you live?");
            Console.WriteLine("This should be a whole number, like 7 for 7%");
            string tax = Console.ReadLine();

            // Convert the sales tax to a decimal, then divie it by 100 to find the value to use for later calculations
            decimal costTax = Decimal.Parse(tax);
            decimal salesTax = costTax / 100;

            // Calculate subtotal, sales tax amount, and grand total. Also get extended prices for each item
            Decimal totalBananas = bananas * costBananaDec;
            Decimal totalBriskets = briskets * costBrisketDec;
            Decimal totalPies = pies * costPieDec;
            Decimal subTotal = (bananas * costBananaDec) + (briskets * costBrisketDec) + (pies * costPieDec);
            Decimal taxTotal = subTotal * salesTax;
            Decimal taxTotalRounded = Math.Round(taxTotal, 2);
            Decimal grandTotal = subTotal + taxTotalRounded;

            // Clear the console and build the final receipt
            Console.Clear();
            Console.WriteLine("\tMcNees Grocery Calculator");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Sales Reeipt");
            Console.WriteLine("Qty\tItem\t\tExtended Price");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(qtyBanana + "\tBanana(s)\t$" + totalBananas);
            Console.WriteLine(qtyBrisket + "\tBrisket(s)\t$" + totalBriskets);
            Console.WriteLine(qtyPie + "\tApple Pie(s)\t$" + totalPies);
            Console.WriteLine("\n\tSubtotal:\t$" + subTotal);
            Console.WriteLine("\tSales Tax @ " + tax + "%\t$" + taxTotalRounded);
            Console.WriteLine("\n\tGrand Total:\t$" + grandTotal);

            /*
             * Tested Values
             * Cost of an Banana            0.40
             * Cost of a Beef Brisket       20.25
             * Cost of Apple Pie            9.75
             * Quantity of Bananas          4
             * Quantity of Beef Briskets    2
             * Quantity of Apple Pies       3
             * Sales Tax In My Area         5
             *
             * Result
             * Total cost of Bananas before tax          $1.60
             * Total cost of Beef Briskets before tax    $40.50
             * Total cost of Apple Pies before tax       $29.25
             * Total cost of all items before tax        $71.35
             * Total sales tax on all items              $3.57
             * Total of all items including tax          $74.92
             *
             * These results were returned as expected
             */
        }
    }
}
