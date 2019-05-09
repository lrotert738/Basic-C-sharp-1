using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mad Lib Homework\n");

            Console.WriteLine("This program will take a series of user entered" +
                " inputs and make a strange story out of the inputs\n\n");

            Console.Write("Please enter a holiday: ");
            string holiday = Console.ReadLine().ToUpper();

            Console.Write("Please enter a structure type (house, barn" +
                " skyscraper, etc: ");
            string structure = Console.ReadLine().ToUpper();

            Console.Write("Please enter a season: ");
            string season = Console.ReadLine().ToUpper();

            Console.Write("Please enter an opening in your structure" +
                " (door, window, skylight, fire escape, etc): ");
            string opening = Console.ReadLine().ToUpper();

            Console.Write("Please enter a celestial body (sun, moon, stars," +
                " planet, etc): ");
            string celetialBody = Console.ReadLine().ToUpper();

            Console.Write("Please enter a type of animal: ");
            string firstAnimal = Console.ReadLine().ToUpper();

            Console.Write("Please enter a different type of animal: ");
            string secondAnimal = Console.ReadLine().ToUpper();

            Console.Write("Please enter persons name: ");
            string name = Console.ReadLine().ToUpper();

            Console.Write("Please enter a type of bird: ");
            string birdType = Console.ReadLine().ToUpper();

            Console.Write("Please enter a type of furniture: ");
            string furniture = Console.ReadLine().ToUpper();

            Console.Write("Please enter a body part (eyes, ears, hand, etc): ");
            string bodyPart = Console.ReadLine().ToUpper();

            Console.WriteLine($"\n\nTwas the night before {holiday} and " +
                $" all through the {structure},");
            Console.WriteLine($"Not a creature was stirring, not "+
                $"even a {firstAnimal},");
            Console.WriteLine("The stockings were hung by the chimney with" +
                " care,");
            Console.WriteLine($"In hopes that {name} would soon be there;");
            Console.WriteLine($"The children were nestled all snug in their {furniture},");
            Console.WriteLine("While visions of sugar plums danc’d in their heads,");
            Console.WriteLine("And Mama in her ‘kerchief, and I in my cap,");
            Console.WriteLine($"Had just settled down for a long {season}'s nap-");
            Console.WriteLine("When out on the lawn there arose such a clatter,");
            Console.WriteLine($"I sprang from the {furniture} to see what was the matter.");
            Console.WriteLine($"Away to the {opening} I flew like a flash,");
            Console.WriteLine("Tore open the shutters, and threw up the sash.");
            Console.WriteLine($"The {celetialBody} on the breast of the new fallen snow,");
            Console.WriteLine("Gave the lustre of mid-day to objects below;");
            Console.WriteLine($"When, what to my wondering {bodyPart } should appear,");
            Console.WriteLine($"But a minature sleigh, and eight tiny {secondAnimal}s,");
            Console.WriteLine("With a little old driver, so lively and quick,");
            Console.WriteLine($"I knew in a moment it must be {name}.");
            //Console.WriteLine("");





        } // end Main()    
    } // end class MadLib
} // end namespace
