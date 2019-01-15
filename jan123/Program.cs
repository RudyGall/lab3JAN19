using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jan123
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            while (runP == true)
            {
                Console.WriteLine("Hello {0}, Please enter an interger value between 1 and 100",
                    firstName);
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("\nYou entered {0}, lets perform the conditional actions!",
                    value);
                if (value % 2 == 0 & value >= 2 & value < 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (value % 2 == 0 & value > 25 & value <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (value % 2 == 0 & value >= 60 & value <= 100)
                {
                    Console.WriteLine("{0}, Even", value);
                }
                else if (value % 2 != 0 & value >= 60 & value <= 100)
                {
                    Console.WriteLine("{0}, Odd", value);
                }
                else if (value % 2 != 0 & value > 1 & value < 100)
                {
                    Console.WriteLine("{0}, Odd", value);
                }
                else if (value % 2 != 0 || value % 2 == 0 & value < 1 || value > 100)
                {
                    Console.WriteLine("Not an integer between 1 and 100");
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
                runP = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}
