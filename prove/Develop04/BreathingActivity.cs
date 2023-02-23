public class BreathingActivity : Activity
{
    private const int _breathInDuration = 4;
    private const int _breathOutDuration = 6;
    public BreathingActivity(){

        _activityName = "Breathing Activity";
    }

    public void BreathRun()
    {
        StartingMessage();
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        Console.WriteLine("Starting activity...");
        WaitForKey();

        var animationTask = Task.Run(() => HoldBreathingAnimation(activityDuration));
        animationTask.Wait();

        Console.WriteLine($"The activity lasted {activityDuration} seconds.");
        EndingMessage();
        WaitForKey();
        // AppControl appControl = new AppControl();
        // appControl.Run();
        
    }

    private void HoldBreathingAnimation(int activityDuration)
    {
        Console.ForegroundColor = ConsoleColor.White;
        string[] message = { "Breathe in...", "Breathe out..."};
        int [] durations = {_breathInDuration, _breathOutDuration};
        int currentMessageIndex = 0;

        while(true)
        {
            Console.WriteLine(message[currentMessageIndex]);
            PauseWithCoutDown(durations[currentMessageIndex]);
            currentMessageIndex = (currentMessageIndex + 1) % message.Length;
            Console.WriteLine();

            CheckTime(activityDuration);
            if (DateTime.Now >= startTime.AddSeconds(activityDuration))
            {
                break;
            }
        }
    }

    // private void PauseWithCoutDown(int activityDuration)
    // {
    //     Console.Write($"({activityDuration})");
    //     for (int i = activityDuration; i > 0; i--)
    //     {
    //         Console.Write($"{i}...");
    //         Thread.Sleep(1000);
    //     }
    //     Console.WriteLine();
    // }
}