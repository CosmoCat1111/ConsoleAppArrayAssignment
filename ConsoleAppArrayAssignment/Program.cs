using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array of strings
            string[] textureArray = { "rough", "sandy", "sharp", "soft", "bumpy", "fuzzy", "furry" };
            //getting user input
            Console.WriteLine("Pick a number between 0-6?");
            int stringChoice = Convert.ToInt32(Console.ReadLine());
            bool myString = false;

            while (!myString)
            {
                try
                {
                    Console.WriteLine("You're favorite texture is:  " + textureArray[stringChoice]);
                    myString = true;
                }
                //message if input isn't within the choices
                catch
                {
                    Console.WriteLine("Sorry, please pick one of the texture options.");
                    stringChoice = Convert.ToInt32(Console.ReadLine());
                }
            }

            //string list
            List<string> woodOptions = new List<string>()
            {
                "Maple", "Cedar", "Alder", "Mahogany", "Juniper", "Spruce", "Arbutus", "Cherry", "Pine", "Birch"
            };
            //input for how many pieces user wants
            Console.WriteLine("\nHow many pieces would you like?");
            int pieceSelect = Convert.ToInt32(Console.ReadLine());
            bool woodString = false;

            while (!woodString)
            {
                try
                {
                    Console.WriteLine("You'll get that many pieces of: " + woodOptions[pieceSelect]);
                    woodString = true;
                }

                catch
                {
                    Console.WriteLine("Sorry, something was not right, please try again.");
                    pieceSelect = Convert.ToInt32(Console.ReadLine());
                }

            }



            //integer array
            int[] intArray = { 1, 2, 22, 3, 33, 4, 44, 5, 55, 6 };
            //user input
            Console.WriteLine("\nPick a random number between 0-9");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("The best number for you is: " + intArray[intSelect]);
                    validInt = true;
                }
                //message if didn't pick number given
                catch
                {
                    Console.WriteLine("Sorry, something wasn't right there, please pick a number from the list above");
                    intSelect = Convert.ToInt32(Console.ReadLine());

                }                    
            }
            Console.ReadLine();
        }
    }
}
