public class ReflectingActivity:Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _remainingQuestions;

    public ReflectingActivity():base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("Why was this experience meaningful to you?");
        // _questions.Add("Have you ever done anything like this before?");
        // _questions.Add("How did you get started?");
        // _questions.Add("What made this time different than other times when you were not as successful?");
        // _questions.Add("What could you learn from this experience that applies to other situations?");
        // _questions.Add("What did you learn about yourself through this experience?");
        // _questions.Add("How can you keep this experience in mind in the future?");

        _prompts.Add("Think of a time when you did something difficult.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you truly did something selfless.");
    }

    public override void Run()
    {
        _remainingQuestions = new List<string>(_questions);
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string read = Reader.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:  ");
        for (var i = 5; i >= 1;i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
        Console.Write("\b ");
        Console.WriteLine();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime && _remainingQuestions.Count > 0)
        {
            GetRandomQuestion();
            ShowSpinner(1000);
        }
        DisplayEndingMessage();
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count); 
        Console.WriteLine($"---{_prompts[index]}---");
    }

    public void GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_remainingQuestions.Count);
        Console.WriteLine($">{_remainingQuestions[index]}");
        _remainingQuestions.RemoveAt(index);
    }
}