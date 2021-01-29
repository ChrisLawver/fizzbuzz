using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;

            Console.WriteLine("Fizz Buzz!");
            Console.WriteLine("Enter -1 to end program");

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
                else if (userNumber == -1)
                {
                    Console.Clear();
                    playGame = false;
                }
                else
                {
                    Console.WriteLine(Convert.ToString(userNumber));
                }
            }

        }
    }
}
