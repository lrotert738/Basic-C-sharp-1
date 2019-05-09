using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM Homework");
            int numTries = 1;
            bool validLogin = false;
            bool exit = false;
            string acctNum;
            decimal acctBal = 0.0m;
            string userOption;

            // step 1a.
            Console.Write("Enter acount number: ");
            acctNum = Console.ReadLine();

            while (numTries < 5)
            {                
                if (acctNum == "123987")
                {
                    // set counter to max num in order to break out of loop
                    // we have correct acct number so no longer need to
                    // keep inputting it
                    numTries = 6;

                    // step 1b
                    Console.Write("Please enter PIN: ");
                    string pinNum = Console.ReadLine();
                    int numPinTries = 1;
                    while (numPinTries < 5)
                    {
                        if (pinNum == "4903")
                        {
                            validLogin = true;
                            numPinTries = 6;
                        } // end if (pinNum == "4903")

                        // else you entered an incorrect PIN number
                        else
                        {
                            Console.Write("Incorrect Pin number, please reenter: ");
                            pinNum = Console.ReadLine();
                            numPinTries++;
                        } // end else you entered an incorrect PIN number

                    } // end while (numPinTries < 5)


                } // end entered correct account number

                // else you entered an incorrect account number
                else
                {
                    Console.Write("Incorrect Account number, please reenter: ");
                    acctNum = Console.ReadLine();
                    numTries++;
                } // end else you entered an incorrect account number

            } // end while loop

            if (validLogin)
            {
                // step 1c.

                // looking at code from CSF1 (week 1) notes we set up a menu
                // in BranchingSwitch.cs class. Since it is similar to what
                // we want in step 1c lets copy the code and alter it for
                // our needs

                // since we want to stay in the menu until the user selects
                // exit a do while loop will work great.  We want to display
                // the menu AT LEAST ONCE.


                do
                {
                    //Console.Clear();
                    Console.WriteLine("\n\nPlease choose a menu option." +
                    " \n1) Deposit\n2) Withdrawal\n3) Balace Inquiry\n4) Exit");
                    userOption = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (userOption)
                    {
                        case "1":
                        case "DEPOSIT":
                        case "D":
                            Console.Write("Please enter your deposit amount (no $ sign): ");
                            decimal amtDep = decimal.Parse(Console.ReadLine());
                            acctBal += amtDep;
                            Console.WriteLine("You deposited {0:c} into account number {1}",
                                amtDep, acctNum);
                            Console.Write("Your new balance is {0:c}\n", acctBal);
                            break;
                        case "2":
                        case "WITHDRAWAL":
                        case "W":
                            Console.Write("Please Enter amount to withdraw: ");
                            decimal amtWith = decimal.Parse(Console.ReadLine());
                            if (acctBal == 0)
                            {
                                Console.WriteLine("Your balance is currently 0." +
                                    " Please make a deposit first");
                                amtWith = 0;
                            }
                            else
                            {
                                while (amtWith > acctBal)
                                {
                                    Console.WriteLine("You don't have that much in your account");
                                    Console.WriteLine("You only have {0:c} in your account",
                                        acctBal);
                                    Console.Write("Please reenter amount to withdraw: ");
                                    amtWith = decimal.Parse(Console.ReadLine());
                                } // end while (amtWith < acctBal)
                            }
                            acctBal -= amtWith;
                            Console.Write("You withdrew {0:c} from account number {1}",
                                amtWith, acctNum);
                            Console.Write(" Your new balance is {0:c}\n", acctBal);
                            break;
                        case "3":
                        case "BALANCE INQUIRY":
                        case "B":
                            Console.Write("Your balance for account number {0} is {1:c}\n",
                                acctNum, acctBal);
                            break;
                        case "4":
                        case "EXIT":
                        case "E":
                            Console.WriteLine("Thank you for your business");
                            exit = true;
                            break;
                        default:
                            break;
                    } // end switch statement
                } while (!exit);

            } // end if (validLogin)

            // else we had an invalid login attempt
            else
            {
                Console.WriteLine("You have been locked out of your account, " +
                    "please contact customer service");
            } // end else we had an invalid login attempt



        } // end Main()
    } // end class ATM
} // end namespace
