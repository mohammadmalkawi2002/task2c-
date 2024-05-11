using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GuessNumber();

            //TakingOrder();

            Console.WriteLine("plz enter number of rows:");
            int nuberOfRows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= nuberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


        }

        static void TakingOrder()
        {
            //store the order and the value of total invoice:
            string Order = "";
            double TotalInvoice = 0.0;

            //loop to take order from the customer:
            while (Order !="exit")
            {
                Console.WriteLine("Enter Your Order from The Menu:(Burger,fries,drink or Zinger)or enter Exit ");
                Order = Console.ReadLine();
                switch (Order)
                {
                    case "Burger":
                        {
                            Console.WriteLine("please enter quantity:");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            TotalInvoice += quantity * 4.5;

                        }
                        break;
                    case "Fries":
                        {
                            Console.WriteLine("please enter quantity:");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            TotalInvoice += quantity * 1.5;

                        }
                        break;
                    case "Drink":
                        {
                            Console.WriteLine("please enter quantity:");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            TotalInvoice += quantity * 1;
                        }
                        break;

                    case "Zinger":
                        {
                            Console.WriteLine("please enter quantity:");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            TotalInvoice += quantity * 2.0;
                        }
                        break;

                    default:
                        Console.WriteLine("Soory!The item is not exist");

                        break;

                }

                double discount = 0.0;
                // calculate discount if the total invoice greater than 15jd:
                if (TotalInvoice > 15)
                {
                    discount = TotalInvoice * 0.05;
                    Console.WriteLine("The total invoice before discount= " + TotalInvoice + "JD");
                    TotalInvoice -= discount;

                    Console.WriteLine("The total invoice after 5% discount= " + TotalInvoice + "JD");
                }
                else { Console.WriteLine("The total invoic=" + TotalInvoice + "JD"); }

            }
        }



        static void GuessNumber()
        {
            //generate the random num
            int Randomnum = new Random().Next(50, 75);
            //initialize userguess ,numof attemps 
            int UserGuess;
            int NumberOfTries = 0;
            int Points = 0;
            //loop continously run 
            while (true)
            {

                Console.WriteLine("Guess the number between 50 to 75:");
                Console.WriteLine(Randomnum);

                UserGuess = Convert.ToInt32(Console.ReadLine());
                NumberOfTries++;// after each attemp increas
                // condition when the user guess num
                if (UserGuess == Randomnum)
                {
                    switch (NumberOfTries)
                    {
                        case 1:
                            {
                                Points += 10;
                                Console.WriteLine("Congratulation!! You wins {0}", Points + "points");
                            }
                            break;

                        case 2:
                            {
                                Points += 7;
                                Console.WriteLine("Congratulation!! You wins {0}", Points + "points");
                            }
                            break;
                        case 3:
                            {
                                Points += 5;
                                Console.WriteLine("Congratulation!! You wins {0}", Points + "points");
                            }
                            break;
                        default:
                            Points = 0;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("plz try again !!");
                }
                Console.WriteLine("You tried " +  NumberOfTries  +  " times");
            }



        }


    }
}

