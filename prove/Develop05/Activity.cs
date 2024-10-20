public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public string getName()
    {
        return _name;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("How long in seconds, would you like for your session?");
        _duration = Convert.ToInt32(Reader.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(350);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");

        ShowSpinner(350);

        Console.WriteLine($"You completed another {_duration} seconds of the {_name}");

        ShowSpinner(350);
    }

    public abstract void Run();

    public void ShowSpinner(int seconds)
    {
        Console.Write("|");
        Thread.Sleep(seconds);
        Console.Write("\b/");
        Thread.Sleep(seconds);
        Console.Write("\b—");
        Thread.Sleep(seconds);
        Console.Write("\b\\");
        Thread.Sleep(seconds);
        Console.Write("\b|");
        Thread.Sleep(seconds);
        Console.Write("\b/");
        Thread.Sleep(seconds);
        Console.Write("\b—");
        Thread.Sleep(seconds);
        Console.Write("\b\\");
        Thread.Sleep(seconds);
        Console.Write("\b|");
        Thread.Sleep(seconds);
        Console.Write("\b/");
        Thread.Sleep(seconds);
        Console.Write("\b—");
        Thread.Sleep(seconds);
        Console.Write("\b\\");
        Thread.Sleep(seconds);
        Console.Write("\b|");
        Thread.Sleep(seconds);
        Console.Write("\b ");
        Console.WriteLine();
    }
}