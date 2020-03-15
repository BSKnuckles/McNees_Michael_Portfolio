using System;
using System.Collections.Generic;

namespace McNees_MIchael_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Michael McNees
             * September 22, 2019
             * SDI - Lists Project
             */

            // Create some variables we'll use throughout the main method
            string firstLocationString;
            string addMore;
            int locationNumber = 1;

            // Create the empty list to hold the vacation destinations
            List<string> locations = new List<string>();

            // Introduce the app and ask the user for the first location they would like to visit
            Console.Clear();
            Console.WriteLine("Vacation Destination Planner\n----------------------------\nAdd location #{0}\n", locationNumber);
            locationNumber++;
            Console.WriteLine("Please name a vacation destination\nyou would like to visit this year:");

            // Collect the first travel location
            firstLocationString = Console.ReadLine();

            // Validate the input
            while (string.IsNullOrWhiteSpace(firstLocationString))
            {
                // Rebuild the header to avoid console clutter
                Console.Clear();
                Console.WriteLine("Vacation Destination Planner\n----------------------------\n");
                //Reprompt the user and tell them what's wrong
                Console.WriteLine("This cannot be blank.\nPlease name a vacation destination\nyou would like to visit this year:");
                // Re-collect the variable for another parse atempt
                firstLocationString = Console.ReadLine();
            }

            // Add this location to the list
            locations.Add(firstLocationString);

            // Rebuild the header to avoid console clutter
            Console.Clear();
            Console.WriteLine("Vacation Destination Planner\n----------------------------\nAdd another location?\n");
            // Ask the user if they would like to add more locations
            Console.WriteLine("Would you like to add any additional vacation locations?\nPlease enter 'Yes' or 'No'.");
            addMore = Console.ReadLine();

            // Loop until the user enters either yes or no with any variation of capitalization
            while (addMore.ToUpper() != "YES" && addMore.ToUpper() != "NO")
            {
                // Let the user know what's wrong and let them try again
                Console.WriteLine("'{0}' is not a valid answer.\nPlease enter only 'Yes' or 'No'.", addMore);
                addMore = Console.ReadLine();
            }

            // Loop to add additional locations when they say yes
            while (addMore.ToUpper() == "YES")
            {

                // Rebuild the header to avoid console clutter
                Console.Clear();
                Console.WriteLine("Vacation Destination Planner\n----------------------------\nAdd location #{0}\n", locationNumber);
                locationNumber++;

                // Ask for the next location
                Console.WriteLine("What is the next location you would like to visit?");

                // Add a validated location to the list through the AddLocation method
                locations.Add(addLocation());

                // Ask if they would like to add more
                // Ask the user if they would like to add more locations
                Console.WriteLine("Would you like to add any additional vacation locations?\nPlease enter 'Yes' or 'No'.");
                addMore = Console.ReadLine();

                while (addMore.ToUpper() != "YES" && addMore.ToUpper() != "NO")
                {
                    // Let the user know what's wrong and let them try again
                    Console.WriteLine("'{0}' is not a valid answer.\nPlease enter only 'Yes' or 'No'.", addMore);
                    addMore = Console.ReadLine();
                }
            }

            // Use a custom method to write out the trip planner results to the user
            TripOutput(locations);

        }

        public static string addLocation()
        {

            // Collect a location location
            string locationString = Console.ReadLine();

            // Validate the Input
            while (string.IsNullOrWhiteSpace(locationString)) {
                // Reprompt the user and tell them what's wrong
                Console.WriteLine("This cannot be blank.\nPlease name a vacation destination\nyou would like to visit this year:");
                Console.WriteLine(locationString);
                // Re-collect the variable for another parse atempt
                locationString = Console.ReadLine();
            }

            return locationString;
        }
        public static void TripOutput(List<string> locations)
        {
            // Rebuild the header to avoid console clutter
            Console.Clear();
            Console.WriteLine("Vacation Destination Planner\n----------------------------\nTrip Planner Results\n");
            // Tell the user the total number of trips they will take this year
            Console.WriteLine("You will take {0} trip(s) this year.", locations.Count);

            // Loop through the list to let the user know all the locations they will visit
            for (int i = 0; i < locations.Count; i++)
            {
                // List the location in the current loop to the user
                Console.WriteLine("You will visit {0} this year.", locations[i]);
            }

            // Thank the user and wish them safe travels
            Console.WriteLine("Thank you for using the program and safe travels!");
        }

        /*
         * Test Values
         *
         * ~~~~~~~~~~~~~~~~~~
         * ~~~~ Test #1 ~~~~~
         * ~~~~~~~~~~~~~~~~~~
         * Input 1 = Italy
         * 
         * Input 2 = yeah
         * 
         * Re-prompted: 'yeah' is not a valid answer. Please enter only 'Yes' or 'No'.
         *
         * Input 3 = England
         *
         * Input 4 = No
         *
         * Final Results:
         * "You will take 2 trips this uyear."
         * "You will visit Italy this year."
         * "YOu will visit England this year."
         * "Thank you for using the program and safe travels!"
         *
         * ~~~~~~~~~~~~~~~~~~
         * ~~~~ Test #2 ~~~~~
         * ~~~~~~~~~~~~~~~~~~
         * Input 1 = " "
         *
         * Re-prompted: "This cannot be blank. Please name a vacation destination you would like to visit this year:"
         *
         * Input 2 = Hollywood
         *
         * Input 3 = yes
         *
         * Input 4 = Las Vegas
         *
         * Input 5 = YES
         *
         * Input 6 = New York
         *
         * Input 7 = no
         *
         * FInal Results:
         * "You will take 4 trips this year."
         * "You will visit San Diego this year."
         * "You will visit Hollywood this year."
         * "You will visit Las Vegas this year."
         * "You will visit New York this year."
         * "Thank you for using the program and safe travels!"
         */
    }
}
