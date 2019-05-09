using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Variables1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create and display some variables\n");
            int wholeNumber = 500;
            char letter = 'A';
            double biggerNum = 99.97;
            float numFloat = 100.663f;
            byte  smallNum = 255;

            Console.WriteLine("The integer variable contains {0}", wholeNumber);
            Console.WriteLine("The char variable contains {0}", letter);
            Console.WriteLine("The double variable contains {0}", biggerNum);
            Console.WriteLine("The float variable contains {0}", numFloat);
            Console.WriteLine("The byte variable contains {0}", smallNum);

            Console.WriteLine("\n\nCreate several arrays of various variables" +
                " and display them using a for loop\n");

            int loopControl = 0;  // used for all the loops
            int[] wholeNumArray = {1, 16, 19, 100, 500 };
            char[] letterArray = { 'a', 'b', 'D', 'T', 'z' };
            string[] namesArray = { "Larry", "Teresa", "Marion", "Doug", "Fred" };
            double[] biggerNumArray = { 11.1, 1000.0, 111.45, 67.67, 3.1457};
            float[] numFloatArray = {123.3f, 45.555f, 67.6767f, 100.1f, 2.000001f };
            byte[] smallNumArray = {1, 45, 90, 100, 200 };

            // Use for loops to display each variable array

            // lets display the integer array first
            Console.WriteLine("\nDisplay the int variable array");
            for (loopControl = 0; loopControl < wholeNumArray.Length; loopControl++)
            {
                Console.WriteLine("The int array contains {0} at index {1}",
                    wholeNumArray[loopControl], loopControl);
            } // end for loop to display the integer array

            // lets display the char array
            Console.WriteLine("\nDisplay the char variable array");
            for (loopControl = 0; loopControl < letterArray.Length; loopControl++)
            {
                Console.WriteLine("The char array contains {0} at index {1}",
                    letterArray[loopControl], loopControl);
            } // end for loop to display the char array

            // lets display the string array
            Console.WriteLine("\nDisplay the string variable array");
            for (loopControl = 0; loopControl < namesArray.Length; loopControl++)
            {
                Console.WriteLine("The string array contains {0} at index {1}",
                    namesArray[loopControl], loopControl);
            } // end for loop to display the string array

            // lets display the double array
            Console.WriteLine("\nDisplay the double variable array");
            for (loopControl = 0; loopControl < biggerNumArray.Length; loopControl++)
            {
                Console.WriteLine("The double array contains {0} at index {1}",
                    biggerNumArray[loopControl], loopControl);
            } // end for loop to display the double array

            // lets display the float array
            Console.WriteLine("\nDisplay the float variable array");
            for (loopControl = 0; loopControl < numFloatArray.Length; loopControl++)
            {
                Console.WriteLine("The float array contains {0} at index {1}",
                    numFloatArray[loopControl], loopControl);
            } // end for loop to display the float array

            // lets display the byte array
            Console.WriteLine("\nDisplay the byte variable array");
            for (loopControl = 0; loopControl < smallNumArray.Length; loopControl++)
            {
                Console.WriteLine("The byte array contains {0} at index {1}",
                    smallNumArray[loopControl], loopControl);
            } // end for loop to display the byte array

            // Assignment 3 - couting loops
            Console.WriteLine();

            Console.WriteLine("\nCount from 0 to 100 by 2's using a while loop");
            int countControl = 0;
            while (countControl <= 100)
            {
                Console.WriteLine("Our counter equals {0}", countControl);
                countControl += 2;
            } // end while (countControl <= 100)

            Console.WriteLine("\nCount from 0 to 100 by 2's using a do while loop");
            countControl = 0;
            do
            {
                Console.WriteLine("Our counter equals {0}", countControl);
                countControl += 2;
            } while (countControl <= 100);  // end do while loop

            Console.WriteLine("\nCount from 0 to 100 by 2's using a for loop");
            for (countControl = 0; countControl <= 100; countControl+=2)
            {
                Console.WriteLine("Our counter equals {0}", countControl);
            } // end for loop















        } // end Main()
    } // end class
} // end namespace
