// Erik Worley
// Git Testing!
using System;

namespace GitTester
{
    class Program
    {
        static void Main()
        {
            int userNumber;
            int counter = 0;
            int number = new Random().Next(1, 101);
            
            Console.WriteLine("I am thinking of a number between 1-100; what is it?");
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
