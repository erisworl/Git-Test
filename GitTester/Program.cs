// Erik Worley
// Git Testing!
using System;

namespace GitTester
{
    class Program
    {
        static void Main()
        {
            int x, y;
            int userNumber;
            int counter = 0;

            Console.WriteLine("Enter the lowest number you would like.");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the highest number you would like.");
            y = Convert.ToInt32(Console.ReadLine());

            int number = new Random().Next(x, y);

            Console.WriteLine("I am thinking of a number between " + x + "-" + y + "; what is it?");
            userNumber = Convert.ToInt32(Console.ReadLine());
            counter++;
            while (userNumber != number)
            {
                if (userNumber < number)
                {
                    Console.WriteLine("The number I am thinking of is higher, try again!");
                    counter++;
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The number I am thinking of is lower, try again!");
                    counter++;
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("You guessed the right number in " + counter + " guess(es)!");

            Console.ReadKey();
        }
    }
}
