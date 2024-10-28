using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();


        Activity activity = new Activity();
        Running running = new Running();
        running.GetDistance(3);
        running.GetMinutes(30);
        running.Calculate();
        _activities.Add(running);

        Biking biking = new Biking();
        biking.GetSpeed(20);
        biking.GetMinutes(40);
        biking.Calculate();
        _activities.Add(biking);

        Swimming swimming = new Swimming();
        swimming.GetLaps(15);
        swimming.GetMinutes(30);
        swimming.Calculate();
        _activities.Add(swimming);

        ReadThroughList();

        void ReadThroughList()
        {
            foreach (var activity in _activities)
            {
                activity.GetSummary();
            }
        }

    }
}