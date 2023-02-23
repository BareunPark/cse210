public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _activityName = "Listing Activity";
    }

    public void ListingRun()
    {
        StartingMessage();
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        

        Console.WriteLine("Starting activity...");
        // WaitForKey();
        Console.WriteLine();

        ListingPromt();
        
        EndingMessage();
        WaitForKey();
        // AppControl appControl = new AppControl();
        // appControl.Run();
    }

    private void ListingPromt()
    {

        RandomPick randompick = new RandomPick();
        string randomListingPromt = randompick.RandomPickRun("lisintgpromts.text");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Consider the following promt:");
        Console.WriteLine();
        Console.WriteLine($"> {randomListingPromt}");
        Console.WriteLine();
        Console.WriteLine($"This activity will last for {activityDuration} seconds.");
        Console.WriteLine("Please list your answer as many as possible");
        Console.WriteLine("Please list your answer below (press 'q' to quit)");
        WaitForKey();
        Console.WriteLine("-------------------------");
        
        List<string> responses = new List<string>();
        string response = "";
       
        DateTime endTime = startTime.AddSeconds(activityDuration);
        while(DateTime.Now < endTime)
        {
            response = Console.ReadLine();
            if(response.ToLower() !="q")
            {
                responses.Add(response);
            }    
            foreach (string r in responses)
            {
                Console.WriteLine($">> {r}");
                
            }

            if (CheckTime(activityDuration))
            {
                break;
            }
            
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count}");
    }

}