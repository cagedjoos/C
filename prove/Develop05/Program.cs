// To exceed the requirements, I made it so that the reflecting activity questions would not repeat themselves until the next question

using System;

class Program
{
    private static List<Activity> activities = new  List<Activity>() { new BreathingActivity(), new ListingActivity(), new ReflectingActivity()};

    static void Main(string[] args)
    {
        int response = 0;


        while (response != 4)
        {
            Console.WriteLine("Menu Options:");
            for(int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. {activities[i].getName()}");
            }
            Console.WriteLine($"{activities.Count + 1}. Quit");
            Console.Write("Select a choice from the menu:");
            string res = Reader.ReadLine();
            int.TryParse(res.Length > 0 ? res.Substring(res.Length - 1) : "", out response);

            if (response > 0 && response < activities.Count + 1)
            {
                Console.Clear();
                activities[response - 1].Run();
            }
            else if (response == activities.Count + 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not an available action, please try again");
            }
        }
    }
}