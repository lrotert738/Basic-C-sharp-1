using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion Homework\n\n");

            Console.WriteLine("This program will take a user entered tempature" +
                " (in Celcisus) on convert it to Fahrenheit");

            Console.Write("Please enter a tempature in Celsius: ");
            float tempC = float.Parse(Console.ReadLine());
            float tempF = tempC * (9.0f / 5.0f) + 32;

            Console.WriteLine("\n{0} degrees Celsius converts to {1} degrees" +
                " Fahrenheight", tempC, tempF);


        }// end Main()
    } // end class TempConverter
} // end namespace
