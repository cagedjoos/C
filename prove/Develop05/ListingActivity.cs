public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _items = new List<string>();

    public ListingActivity():base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:  ");
        for (var i = 5; i >= 1;i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
        Console.Write("\b ");
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            if (DateTime.Now < futureTime)
            {
                try
                {
                    string answer = Reader.ReadLine((int)(futureTime - DateTime.Now).TotalMilliseconds);
                    _items.Add(answer);
                }
                catch(TimeoutException)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                break;
            }
        }
        foreach (var item in _items)
        {
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---"); 
    }
}