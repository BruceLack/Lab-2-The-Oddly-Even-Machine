using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1;
            Console.WriteLine("Welcome to the Oddly Even Machine!");
            Console.WriteLine("Please enter a username: ");
            string myName = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter a whole number between 1 and 100: ");
                int myNum = int.Parse(Console.ReadLine());
                if (myNum < 1 || myNum > 100)
                {
                    Console.WriteLine(myName + " The number you entered is invalid. Please enter a whole number between 1 and 100.");
                }
                else if (myNum % 2 != 0 && myNum > 60)
                {
                    Console.WriteLine(myName + " " + myNum + " is Odd");
                }
                else if (myNum % 2 != 0)
                {
                    Console.WriteLine(myName + " that number is Odd");
                }
                else if (myNum % 2 == 0 && myNum < 25)
                {
                    Console.WriteLine(myName + " that number is Even and less than 25");
                }
                else if (myNum % 2 == 0 && myNum <= 60)
                {
                    Console.WriteLine(myName + " that number is Even");
                }
                else if (myNum % 2 == 0 && myNum > 60)
                {
                    Console.WriteLine(myName + " " + myNum + " is Even");
                }
                
                Console.WriteLine("Would you like to continue? (y/n)");
                answer1 = Console.ReadLine();
            }
            while (answer1 == "y");
            Console.WriteLine(myName + ", " + "Thank you for using the Oddly Even Machine");
        }

    }
}