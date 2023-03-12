class AppControl
{
    
    private Goal goalList = new Goal( "", "", 0 );
    
    SimpleGoal simpleGoal = new SimpleGoal( "", "", 0 );
    private EternalGoal eternalGoal = new EternalGoal( "", "", 0 );
    private ChecklistGoal checklistGoal = new ChecklistGoal( "", "", 0, 0, 0);
    
    public void Run()
    {   
        
        string option = "";

        while(option != "6")
        {
            Console.WriteLine($"You have {goalList.TotalPoint} points");
            Console.WriteLine();
            Console.WriteLine("Option available: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please select your option: ");
            
            try
            {
                option = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadKey();
                continue;
            }

            switch (option)
            {
                case "1":
                    CreateGoalRun();
                    break;
                case "2":
                    goalList.ListGoals();
                    break;
                case "3":
                    SaveToFile("goallists.txt");
                    break;
                case "4":
                    LoadFromFile("goallists.txt");
                    break;
                case "5":
                    goalList.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("6");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    continue;
                
            }
        }
    }

    public void CreateGoalRun()
    {

        string goalOption = "";
        while(goalOption !="4")
        {
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Quit to Menu");
            Console.Write("Please select your option: ");

            try
            {
                goalOption = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadKey();
                continue;
            }
            switch(goalOption)
            {
                case "1":
                    SimpleGoal.CreateSimpleGoal(goalList);
                    break;
                    
                case "2":
                    eternalGoal.CreateEternalGoal();
                    break;
                case "3":
                    checklistGoal.CreateChecklistGoal();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    continue;
            }
        }

    }

    
    public void SaveToFile(string filename)
    {
        File.WriteAllText(filename, string.Empty);
        using (StreamWriter sw = File.AppendText(filename))
        {
            sw.WriteLine(goalList.TotalPoint);
            // List<Goal> goalsCopy = new List<Goal>(goalList._goals);
            foreach (var goal in goalList._goals)
            {
                string checkbox = goal.IsAchieved ? "true" : "false";
                sw.WriteLine($"{goal.Name}, {goal.Description}, {goal.Points}, {checkbox}");
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Goal saved to {filename}.txt");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void LoadFromFile(string filename)
    {
    goalList._goals.Clear();
    using (StreamReader sr = new StreamReader(filename))
    {
        string line;
        int lineCount = 0;
        while ((line = sr.ReadLine()) !=null)
        {
            string[] data = line.Split(',');
            if (lineCount == 0 )
            {
                goalList.TotalPoint = int.Parse(data[0]);
            }
            else
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool IsAchieved = bool.Parse(data[3]);
                
                Goal goal = new Goal( name, description, points );
                
                goal.IsAchieved = IsAchieved;
                
                goalList._goals.Add(goal);
            }
            lineCount++;
        }
    }



    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"Goal loaded from {filename}.txt");
    Console.ForegroundColor = ConsoleColor.White;
    }
}