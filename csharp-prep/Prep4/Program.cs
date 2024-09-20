using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        
        while (number != 0)
        {
            Console.Write("Enter a number (If you want to quit enter 0): ");
            string numberAnswer = Console.ReadLine();
            number = int.Parse(numberAnswer);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;

        foreach (int numberOne in numbers)
        {
            total += numberOne;
        }

        Console.WriteLine($"The total of all of the numbers is {total}.");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of all of the numbers is {average}.");

        int largeNum = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largeNum)
            {
                largeNum = num;
            }
        }

        Console.WriteLine($"The largest number is {largeNum}");
    }
}