using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            decimal newBalance;
            Console.WriteLine("Interest Calculation Homework\n");

            Console.WriteLine("This program will ask the user for a beginning "+
                "balance, interest rate and number of years\n");
            Console.WriteLine("We will then calculate and display the amount " +
                "that they will have after the specified number of years");

            Console.Write("\n\nPlease enter your beginning balance: (NO dollar sign pls) ");

            // get input and parse it into a decimal value (convert from string to number)
            decimal begBalance = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate offered (.05 for 5 %, .125 for 12.5% etc): ");

            // get input and parse it into a decimal value (convert from string to number)
            decimal interestRate = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the number of years you want to check (whole years only): ");
            // get input and parse it into a decimal value (convert from string to number)
            double tempYears = double.Parse(Console.ReadLine());

            // let's remove any decimal number entered inadverently. This will truncate and NOT round!!
            int numYears = (int)tempYears;

            newBalance = begBalance;
            
            for (int i = 1; i <= numYears; i++)
            {                
                newBalance = newBalance + (newBalance * interestRate);                
            } // end for loop to figre the compound interest

            string plural = (numYears != 1) ? "s" : "";
            Console.WriteLine("\n\nThe amount you will have in {0} year{1} is {2:c}",
                    numYears, plural, newBalance);








        } // Main()
    } // end class InterestCalc
} // end namespace
