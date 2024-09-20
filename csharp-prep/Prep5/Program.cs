using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number.");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }

        static int SquareNumber(int number)
        {
            int squareNum = number * number;
            return squareNum;
        }

        static void DisplayResult(string name, int squareNum)
        {
            Console.WriteLine($"{name} your number squared is {squareNum}");
        }

    }
}