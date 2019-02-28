using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madLibs
{
    class madLibs
    {
        static void Main(string[] args)
        {
            // This is a basic sample program to practice reading and writing from the console
            // This mad libs example is from "https://hobbylark.com/party-games/How-to-Make-Your-Own-Mad-Libs"

            // variable declarations, all strings
            string name, adj1, adj2, birdType, roomInHouse, pastVerb, verb1, relName, noun1, liquid, verbIng1, bodyPart, pluralNoun, verbIng2, noun2;
           
            // Ask users name, and get information for the story, and assigning variables
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("Hello " + name + ". Enter an adjective: ");
            adj1 = Console.ReadLine();
            Console.Write("Enter another adjective: ");
            adj2 = Console.ReadLine();
            Console.Write("Name a type of bird: ");
            birdType = Console.ReadLine();
            Console.Write("Name a room in your house: ");
            roomInHouse = Console.ReadLine();
            Console.Write("Past tense of any verb: ");
            pastVerb = Console.ReadLine();
            Console.Write("Choose any verb: ");
            verb1 = Console.ReadLine();
            Console.Write("Enter a relatives name: ");
            relName = Console.ReadLine();
            Console.Write("Pick a noun: ");
            noun1 = Console.ReadLine();
            Console.Write("Entar any liquid: ");
            liquid = Console.ReadLine();
            Console.Write("Name any verb ending in ing: ");
            verbIng1 = Console.ReadLine();
            Console.Write("Pick a body part: ");
            bodyPart = Console.ReadLine();
            Console.Write("Name a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Name another verb ending in ing: ");
            verbIng2 = Console.ReadLine();
            Console.Write("Name another noun: ");
            noun2 = Console.ReadLine();

            // Prints story to console
            Console.WriteLine("It was a " + adj1 + ", cold November day. I woke up to the " + adj2 + " smell of " + birdType +
                " roasting in the " + roomInHouse + " downstairs.");
            Console.WriteLine("I " + verb1 + " down the stairs to see if I could help " + verb1 + " the dinner. My mom  said, See if " + relName + " needs a fresh " + noun1 + ".");
            Console.WriteLine(" So I carried a tray of glasses full of " + liquid + " into the " + verbIng1 + " room. When I got there, I couldn't believe my " + bodyPart + "! There were " + pluralNoun + verbIng2 + " on the " + noun2 + "!");
           

        
            // Pause 
            Console.ReadLine();

        }
    }
}
