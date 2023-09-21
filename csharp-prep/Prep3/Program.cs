using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = 0;
        
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }                    
    }
}