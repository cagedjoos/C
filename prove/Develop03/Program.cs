using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Alma", 26, 12, "Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("Thanks for memorizing!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        }
    }
}