using System;
using System.IO;

namespace GolfScorecard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHoles;
            int[] scores;
            int totalScore = 0;
            int numberOfBirdies = 0;

            Console.WriteLine("Reading in scorecard...");

            try
            {
                using (StreamReader reader = new StreamReader("scorecard.txt"))
                {
                    numberOfHoles = int.Parse(reader.ReadLine());
                    scores = new int[numberOfHoles];

                    for (int i = 0; i < numberOfHoles; i++)
                    {
                        scores[i] = int.Parse(reader.ReadLine());
                        totalScore += scores[i];

                        if (scores[i] == 3)
                        {
                            numberOfBirdies++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the scorecard: " + ex.Message);
                return;
            }

            Console.WriteLine("Scorecard read successfully!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("1. Display current score");
                Console.WriteLine("2. Display total score");
                Console.WriteLine("3. Display number of birdies");
                Console.WriteLine("4. Exit");

                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine("Current score:");

                    for (int i = 0; i < numberOfHoles; i++)
                    {
                        Console.WriteLine("Hole " + (i + 1) + ": " + scores[i]);
                    }

                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Total score: " + totalScore);
                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Number of birdies: " + numberOfBirdies);
                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                    Console.WriteLine();
                }
            }
        }
    }
}

