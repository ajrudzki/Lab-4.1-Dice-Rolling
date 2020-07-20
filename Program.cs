using System;
using System.ComponentModel;
using System.Linq;

namespace Lab_4._1_Dice_Rolling
{
    class Program
    {

        static void PrintDiceCombo(int total)
        {
            if (total == 2)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if (total == 3)
            {
                Console.WriteLine("Ace Deuce!");
            }
            else if (total == 12)
            {
                Console.WriteLine("Box Cars!");
            }
            else if (total == 7 || total == 11)
            {
                Console.WriteLine("Win!");
            }

            if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine("Craps!");
            }
                                                
        }
  

    static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to the Grand Circus Casino!");
            Console.Write($"How many sides should each die have?: ");

            string entry = Console.ReadLine();
            int diceSides = int.Parse(entry);

            int rollCount = 1;
            bool running = true;
            while (running)
            {
                
                Random dice1 = new Random();
                Random dice2 = new Random();
               
                Console.WriteLine();                        
                Console.WriteLine($"Roll {rollCount}:"); //adds a roll counter to each time the user re-rolls
                rollCount++;

                int result1 = dice1.Next(1, diceSides + 1);
                int result2 = dice2.Next(1, diceSides + 1);
                int sum = result1 + result2;

                Console.WriteLine($"You rolled a {result1} and a {result2} ({sum} total)");               
                if (diceSides == 6)
                {
                    PrintDiceCombo(sum);
                }

                Console.Write($"Roll again? (y/n): ");
                
                string cont = Console.ReadLine();
                if (cont == "yes" || cont == "Yes" || cont == "y" || cont == "Y")
                {
                    running = true;
                    {
                        //Console.Clear();
                    }
                }
                else if (cont == "no" || cont == "No" || cont == "n" || cont == "N")
                {
                    running = false;
                    {
                        Console.WriteLine();
                        Console.Write($"Thanks for Playing!!");
                    }

                }

            }

        }

    }

}
