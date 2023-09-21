using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput;
        do
        {
            Console.Write("Enter series of numbers ( type 0 to stop): ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0);

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum number
        int maxNumber = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The maximum number is: {maxNumber}");
    }
}