using System;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        while (result != 5)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string pick = Console.ReadLine();
            result = int.Parse(pick);
            if (result == 1)
            {
                Entry entry = new Entry();
                string Prompt1 = promptGenerator.GetRandomPrompt();
                Console.WriteLine(Prompt1);
                entry._promptText = Prompt1;
                string entrytext = Console.ReadLine();
                entry._entryText = entrytext;
                DateTime date = DateTime.Now;
                string dateText = date.ToShortDateString();
                entry._date = dateText;
                journal.AddEntry(entry);
            }
            else if (result == 2)
            {
                journal.DisplayAll();
            }
            else if (result == 3)
            {
                Console.WriteLine("What is the file name?");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (result == 4)
            {
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (result == 5)
            {
                Console.WriteLine("Thanks for journaling!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, that is not an available action. Please try again.");
            }

        }
    }
}