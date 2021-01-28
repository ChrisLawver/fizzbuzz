using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;

            Console.WriteLine("Fizz Buzz!");


            while (playGame == true)
            {
                Console.Write("\nEnter a number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber % 3 == 0 && userNumber % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (userNumber % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (userNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(Convert.ToString(userNumber));
                }
            }

        }
    }
}
