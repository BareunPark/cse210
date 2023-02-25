public class Activity
{
    protected string _activityName;
    // private int _pauseSeconds;
    public int activityDuration;
    public DateTime startTime;

    // public void Run()
    // {
    //     StartingMessage();

    //     Console.WriteLine("Starting activity...");
    //     var animationTask = Task.Run(() => HoldAnimation(activityDuration));
    //     animationTask.Wait();

    //     EndingMessage();
    // }
    public void StartingMessage()
    {
        
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName}.");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.Write("(This activity should be more than 10 seconds)");
        
        activityDuration = Convert.ToInt32(Console.ReadLine());
        HoldAnimation(10);

        startTime = DateTime.Now;
        
    }

    public void HoldAnimation(int _pauseSeconds)
    {
        string [] spinnerFrames = {"|", "/", "-", "\\"};

        for (int i = 0; i < _pauseSeconds; i++)
        {
            Console.Write(spinnerFrames[i % spinnerFrames.Length]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
           
        }
    }

   
    public void EndingMessage()
    {
        
        
        Console.WriteLine($"You have finsished {_activityName}.");
        HoldAnimation(10);
        // WaitForKey();
        
        
    }

    public bool CheckTime(int activityDuration)
    {
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(activityDuration * 1000);

        if(DateTime.Now >= startTime.AddSeconds(activityDuration * 1000))
        {
            Console.WriteLine($"Time is up for {_activityName}. Press any key to finish.");
            return true;
        }
        return false;

       
    }

    public void WaitForKey()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\nPress any Key to continue");
        Console.ReadKey(true);
        Console.ForegroundColor = ConsoleColor.White;
    }
    
    public void PauseWithCoutDown(int activityDuration)
    {
        Console.Write($"({activityDuration})");
        for (int i = activityDuration; i > 0; i--)
        {
            Console.Write($"{i}...");
            Console.Write("\b\b\b\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}