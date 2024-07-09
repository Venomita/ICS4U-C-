using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starshape
{
    class Program
    {
        static void Main(string[] args) { 
            int i, j, k;

            for (i = 1; i <= 10; i++)
            {
                for (j = i; j< 10; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
    Console.WriteLine();
            }
            Console.ReadKey();
            /*
                        Console.WriteLine();
                        Console.WriteLine();

                        for (int x = 1; x <= 10; x++)
                        {
                            Console.Clear();
                            for (i = 1; i <= 10; i++)
                            {
                                for (j = i + x; j< 10; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (k = 1; k<(i* 2); k++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            System.Threading.Thread.Sleep(100);
                        }

                        Console.ReadKey();
                    /*{
                        for (int a = 1; a < 5; a++)
                        {
                            String indent = "   ";
                            Console.WriteLine("                        *\r\n" +
                                "                       ***\r\n" +
                                "                     *******\r\n" +
                                "                   **********\r\n" +
                                "                        *\r\n" +
                                "                        *\r\n" +
                                "                        *\r\n");
                            Console.ReadLine();*/

            /*Console.Write("Welcome to Hamza's Apple store. Here, we sell Apples!\r\nThe price of one apple is $2.50 ");
            Console.Write("How many apples would you like to purchase?: ");
            int quantity = Console.Read();
            double cost = 2.5;
            double subtotal = quantity * cost;
            Console.WriteLine("Subtotal calculation done. ");
            Console.WriteLine("You would like to purchase " + quantity + " apples. Your total is " + subtotal + " before tax.");
            Console.WriteLine("Order summary done. ");
            double tax = 1.13;
            double fTotal = subtotal * tax;
            Console.WriteLine("Final total calculation done. ");
            double tTax = fTotal - subtotal;
            Console.WriteLine("Tax: " + tTax);
            Console.WriteLine("Your final total is " + fTotal);
            Console.ReadLine();*/
        }
        }
    }
