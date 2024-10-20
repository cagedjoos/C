public class BreathingActivity:Activity
{
    public BreathingActivity():base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in:  ");
            for (var i = 4; i >= 1;i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
            Console.Write("\b ");
            Console.WriteLine();
            Console.Write("Now breathe out:  ");
            for (var i = 6; i >= 1;i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
            Console.Write("\b ");
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
        Console.Clear();
    }
}