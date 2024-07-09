/*using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OneDice!");

            do
            {
                int roll = RollDice();
                Console.WriteLine("You rolled a {0}!", roll);

                Console.Write("Roll again? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y")
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Thanks for playing OneDice!");
        }

        static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
*/
using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TwoDice!");

            do
            {
                int[] rolls = RollDice(2);
                Console.WriteLine("You rolled a {0} and {1}! Your total is: {2}.", rolls[0], rolls[1], rolls[0] + rolls[1]);

                Console.Write("Roll again? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y")
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Thanks for playing TwoDice!");
        }

        static int[] RollDice(int count)
        {
            Random random = new Random();
            int[] rolls = new int[count];

            for (int i = 0; i < count; i++)
            {
                rolls[i] = random.Next(1, 7);
            }

            return rolls;
        }
    }
}
