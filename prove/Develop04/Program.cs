using System;

class Program
{
    static void Main(string[] args)
    {
        AppControl appControl = new AppControl();
        appControl.Run();
    }
}

class AppControl
{
    public void Run()
    {
        // Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionactivity = new ReflectionActivity();
        ListingActivity lstingactivity = new ListingActivity();

        // string option;
        // do {
        //     Console.Clear();
        //     Console.WriteLine("Select an option: ");
        //     Console.WriteLine("1. Start Breathing Activity");
        //     Console.WriteLine("2. Start Reflecting Activity");
        //     Console.WriteLine("3. Start Listening Activity");
        //     Console.WriteLine("4. Quit");

        //     option = Console.ReadLine();
        //     switch (option)
        //     {
        //         case "1":
        //             breathingActivity.BreathRun();
        //             break;
        //         case "2":
        //             Console.WriteLine("2");
        //             break;
        //         case "3":
        //             Console.WriteLine("3");
        //             break;
        //         case "4":
        //             break;
        //         default:
        //             Console.WriteLine("Invalid option. Please try again.");
        //             Console.ReadKey();
        //             break;
        //     }
        // } while(option != "4");

        string option = "";
        while(option !="4") 
        {
            Console.Clear();
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            // activity.WaitForKey();

            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    breathingActivity.BreathRun();
                    break;
                case "2":
                    reflectionactivity.ReflectionRun();
                    break;
                case "3":
                    lstingactivity.ListingRun();
                    break;
                case "4":
                    option = "4";
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    continue;
            }
        } 

        
    }
}

