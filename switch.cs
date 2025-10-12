
/*
using System;

public class Program
{
    static void Main(string[] args)
    {
        int TotalCoffeeCost = 0;
        bool continueOrder = true;




        while (continueOrder)
        {
            Console.WriteLine("Welcome to our Coffee Shop");
            Console.WriteLine("Please select your coffee size:");
            Console.WriteLine("1. Small Coffee - $1");
            Console.WriteLine("2. Medium Coffee - $2");
            Console.WriteLine("3. Large Coffee - $3");
            Console.WriteLine("Enter your choice (1, 2, or 3): ");

        
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    Console.WriteLine("You selected Small Coffee ($1)");
                    break;

                case 2:
                    TotalCoffeeCost += 2;
                    Console.WriteLine("You selected Medium Coffee ($2)");
                    break;

                case 3:
                    TotalCoffeeCost += 3;
                    Console.WriteLine("You selected Large Coffee ($3)");
                    break;

                default:
                    Console.WriteLine("Invalid option! Please choose again.");
                    continue; 
            }

            Console.WriteLine("Do you want to order another coffee? (yes/no)");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == "no")
            {
                continueOrder = false;
            }
        }

        Console.WriteLine($"Total Coffee Cost = ${TotalCoffeeCost}");
        Console.WriteLine("Thank you for visiting our Coffee Shop!");
    }

}

*/