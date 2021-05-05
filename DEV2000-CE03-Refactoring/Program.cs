using System;
using System.Collections.Generic;

// Name: Jones, James
// Date: 05/04/2021
// Course: APD: DEV2300-O 01: Application Program Development
// Synopsis: Everyone loves a great vacation! This application helps you keep track of all the wonderful places on your bucket list.

namespace TravelPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            // Display header
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine(" TRAVEL PLANNER ");
            Console.WriteLine("========================================");
            Console.WriteLine("");
            Console.WriteLine("Helping you keep track of the places you will travel. \r\n");

            // Create List
            List<string> locations = Itinerary.Plan();

            //Display List
            Itinerary.Display(locations);

            // Display footer
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("Safe travels on your future trips!");
            Console.WriteLine("");
        }

    // End class
    }
}
