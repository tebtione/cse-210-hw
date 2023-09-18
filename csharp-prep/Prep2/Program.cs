using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letter = "";

        if (percent >= 90)
            {
            letter = "A"; 
            }
            else if (percent >= 80)
            {
            letter = "B";
            }
            else if (percent >= 70)
            {
            letter = "C";
            }
            else if (percent >= 60)
            {
            letter = "D";
            }
        else
            {
            letter = "F";
            }

        Console.WriteLine($"Your letter grade is: {letter}");
        
        if (percent >= 70)
            {
            Console.WriteLine("Congratulate! You Pass the Class!");
            }
        else
            {
            Console.WriteLine("Try Harder Next Time");
            }
    }

}