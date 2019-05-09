using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MinMaxAvg Assignment");

            double[] numArray = new double[5];
            double average = 0;
            double totalArray = 0;
            Console.WriteLine("We will input 5 different numbers and display the highest, lowest and average\n");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Input a number");
                numArray[i] = double.Parse(Console.ReadLine());
                totalArray += numArray[i];
            } // end for (int i = 0; i < numArray.Length; i++)

            Array.Sort(numArray);
            average = totalArray / numArray.Length;

            Console.WriteLine($"\nThe lowest number input is: {numArray[0]}");
            Console.WriteLine($"This highest number input is: {numArray[numArray.Length-1]}");
            Console.WriteLine($"The average of the numbers input is {average}");

        } // end Main()
    } // end class MinMaxAvg
} // end namespace
