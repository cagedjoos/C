using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);
        int guessnumber = -1;
        while (guessnumber != magicnumber)
        {
            Console.Write("What is your guess?");
            guessnumber = int. Parse(Console.ReadLine());


            if (guessnumber > magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessnumber < magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed It!");
            }
        }
    }
}