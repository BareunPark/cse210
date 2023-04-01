using System;

namespace ExerciseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(DateTime.Now, 30, 4.8));
            activities.Add(new Cycling(DateTime.Now.AddDays(-1), 45, 20));
            activities.Add(new Swimming(DateTime.Now.AddDays(-2), 60, 30));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.ReadLine();
        }
    }

}