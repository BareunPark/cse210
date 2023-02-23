public class ReflectionActivity : Activity
{
    public ReflectionActivity(){
        _activityName = "Reflection Activity";
    }

    public void ReflectionRun()
    {
        StartingMessage();
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        Console.WriteLine("Starting activity...");
        WaitForKey();
        Console.WriteLine();

        
        Promt();
        Question();

        EndingMessage();
        WaitForKey();
        // AppControl appControl = new AppControl();
        // appControl.Run();
    }

    private void Promt()
    {
        RandomPick randompick = new RandomPick();
        string randomPromt = randompick.RandomPickRun("reflectionpromts.text");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Consider the following promt:");
        Console.WriteLine();
        Console.WriteLine($"> {randomPromt}");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("(When you have something in mind, press enter to continue.)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey(true);
        
    }

    private void Question()
    {
        
        RandomPick randompick = new RandomPick();
        List<string> askedQuestions = new List<string>();
        int numQuestions = activityDuration / 10;
        // string [] questions = {randompick.RandomPickRun("reflectionquestions.text")};
        // string randomQuestion1 = randompick.RandomPickRun("reflectionquestions.text");
        // string randomQuestion2 = randompick.RandomPickRun("reflectionquestions.text");
        // string randomQuestion3 = randompick.RandomPickRun("reflectionquestions.text");
        // string randomQuestion4 = randompick.RandomPickRun("reflectionquestions.text");
        // string randomQuestion5 = randompick.RandomPickRun("reflectionquestions.text");
        // string randomQuestion6 = randompick.RandomPickRun("reflectionquestions.text");
        // string [] questions = {randomQuestion1, randomQuestion2, randomQuestion3, randomQuestion4, randomQuestion5, randomQuestion6};

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experiece.");
        Console.WriteLine($"It will last for {activityDuration} seconds");
        WaitForKey();

        
        // int questionIndex = 0;
        
        
        
        DateTime endTime = startTime.AddSeconds(activityDuration);
        
        while(DateTime.Now < endTime)
        {
            // Console.WriteLine($"> {questions[questionIndex]}");
            // questionIndex = (questionIndex + 1) % questions.Length;
           
            // Thread.Sleep(10000);
            for (int i = 0; i < numQuestions; i++)
            {
                string randomQuestion;
                do
                {
                    randomQuestion = randompick.RandomPickRun("reflectionquestions.text");
                }
                while(askedQuestions.Contains(randomQuestion));
                askedQuestions.Add(randomQuestion);

                Console.WriteLine($"> {randomQuestion}");
                if (CheckTime(activityDuration))
                {
                    break;
                }
                Thread.Sleep(10000);
            }
            

        }
    }

    
}