using System;

namespace Months_of_the_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number correlates with the month?");
            Console.Write("Pick a number: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12; ");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "January! ";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "February";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "March";
                Console.WriteLine(message);
            }
            else if (userValue == "4")
            {
                string message = "April";
                Console.WriteLine(message);
            }
            else if (userValue == "5")
            {
                string message = "May";
                Console.WriteLine(message);
            }
            else if (userValue == "6")
            {
                string message = "June";
                Console.WriteLine(message);
            }
            else if (userValue == "7")
            {
                string message = "July";
                Console.WriteLine(message);
            }
            else if (userValue == "8")
            {
                string message = "August";
                Console.WriteLine(message);
            }
            else if (userValue == "9")
            {
                string message = "September";
                Console.WriteLine(message);
            }
            else if (userValue == "10")
            {
                string message = "October";
                Console.WriteLine(message);
            }
            else if (userValue == "11")
            {
                string message = "November";
                Console.WriteLine(message);
            }
            else if (userValue == "12")
            {
                string message = "December";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry we didn't undderstand!";
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}
