  using System;
using System.Collections.Generic;

// Name: Jones, James
// Date: 05/04/2021
// Course: APD: DEV2300-O 01: Application Program Development
// Synopsis: Collection of methods used in the planning and displaying of travel itinerary locations.

namespace TravelPlanner
{
    public class Itinerary
    {

        // Plan itinerary
        public static List<string> Plan()
        {

            // Create list for locations
            List<string> locations = new List<string>();

            // Repeat until all locations are added
            bool planning = true;
            while (planning)
            {

                locations.Add(GetLocation());

                planning = ContinuePlanning(planning);

            }

            return locations;
        }


        // Request location from user. Needs to be "public" to use in another code class.
        private static string GetLocation()
        {

            // Initial request
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.Write("Where would you like to travel? ");
            string location = Console.ReadLine();

            // Validate user input 
            while (String.IsNullOrWhiteSpace(location))
            {
                // Reminder not to leave blank
                Console.WriteLine("Please do not leave this blank! \r\n");

                // Ask again where they would like to go
                Console.Write("Where would you like to travel? ");

                // String for user input
                location = Console.ReadLine();
            }

            return location;
        }


        // Question - another location? Only being accessed inside of the Itinerary class.
        private static bool ContinuePlanning(bool planning)
        {
            

            // Another location?
            Console.Write("Another location? (yes/no) ");
            string response = Console.ReadLine();

            // Validate user input
            while (response.ToLower() != "yes" && response.ToLower() != "no")
            {
                // Error message
                Console.WriteLine("Please only enter yes or no.");

                // Re-ask question
                Console.Write("Another location? (yes/no) ");
                response = Console.ReadLine();
            }

            // Continue planning?
            if (response.ToLower() == "no")
            {
               planning = false;
            }

            return planning;
        }

 
        // Display itinerary locations
        public static void Display(List<string> locations)
        {

            //Output the number of locations the user will visit
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine($" You will take {locations.Count} trip(s).");

            //Output each location the user will visit
            for (int i = 0; i < locations.Count; i++)
            {   //string interpolation
                Console.WriteLine($" You will visit {locations[i]}.");
            }

        }


    // End class
    }
}