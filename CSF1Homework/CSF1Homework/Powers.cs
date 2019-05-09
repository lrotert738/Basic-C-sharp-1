using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Powers of Numbers Assignment");
            long powerOfTwo = 1;
            for (int i = 1; i <= 50; i++)
            {
                powerOfTwo *= 2;
                Console.WriteLine("2 raised to the {0} power is: {1}", i, powerOfTwo);
            }

        } // end Main()
    } // end class Powers
} // end namespace
