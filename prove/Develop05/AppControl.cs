class AppControl
{
    
    private List<Goal> goals = new List<Goal>();
    
    public void Run()
    {   
        
        string option = "";

        while(option != "6")
        {
            Console.WriteLine($"You have {ComputeTotalPoint()} points");
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
                    ListGoals();
                    break;
                case "3":
                    SaveToFile();
                    break;
                case "4":
                    LoadFromFile();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
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
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    goals.Add(simpleGoal);
                    break;
                    
                case "2":
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goals.Add(eternalGoal);
                    break;
                case "3":
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goals.Add(checklistGoal);
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

    public void ListGoals()
    {
        Console.Clear();
        foreach (Goal goal in goals)
        {
            if (goal is SimpleGoal)
            {
                SimpleGoal simpleGoal = (SimpleGoal)goal;
                Console.WriteLine($"{goal.GetType()} >> {simpleGoal.PrintProgress()} {simpleGoal.GetName()} : {simpleGoal.GetDescription()}");
            }
            if (goal is EternalGoal)
            {
                EternalGoal eternalGoal = (EternalGoal)goal;
                Console.WriteLine($"{goal.GetType()} >> {eternalGoal.PrintProgress()} {eternalGoal.GetName()} : {eternalGoal.GetDescription()}");
            }
            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                Console.WriteLine($"{goal.GetType()} >> {checklistGoal.PrintProgress()} {checklistGoal.GetName()} : {checklistGoal.GetDescription()} ----- Completed {checklistGoal.GetProgress()}/{checklistGoal.GetHowMany()}");
            }
        }
        
    }

    public void RecordEvent()
    {
        Console.Clear();
        

        Console.WriteLine("Select a goal to update its progress:");
        int index = 1;
        foreach (Goal goal in goals)
        {
            if (goal is SimpleGoal)
            {
                SimpleGoal simpleGoal = (SimpleGoal)goal;
                Console.WriteLine($"{index}. {simpleGoal.GetType()} >> {simpleGoal.PrintProgress()} {simpleGoal.GetName()} : {simpleGoal.GetDescription()} - {simpleGoal.GetPoint()} points");
            }
            if (goal is EternalGoal)
            {
                EternalGoal eternalGoal = (EternalGoal)goal;
                Console.WriteLine($"{index}. {eternalGoal.GetType()} >> {eternalGoal.PrintProgress()} {eternalGoal.GetName()} : {eternalGoal.GetDescription()} - {eternalGoal.GetPoint()} points");
            }
            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                Console.WriteLine($"{index}. {checklistGoal.GetType()} >> {checklistGoal.PrintProgress()} {checklistGoal.GetName()} : {checklistGoal.GetDescription()} - {checklistGoal.GetPoint()} points ----- Completed {checklistGoal.GetProgress()}/{checklistGoal.GetHowMany()}");
            }
           
            
            index ++;
        }

        Console.WriteLine("Enter the number of the goal (or 'quit' to exit): ");
        
        int choice = int.Parse(Console.ReadLine());

        
        while (choice < 1 || choice > goals.Count)
        {
            Console.Write("Enter the number of the goal (or 'quit' to exit): ");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                return;
            }
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }
            if (choice < 1 || choice > goals.Count)
            {
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {goals.Count}.");
                continue;
            }
            else
            {
                break;
            }
      
        }

        Goal selectedGoal = goals[choice - 1];
        selectedGoal.RecordEvent();
        
        Console.WriteLine($"You have earned {selectedGoal.GetPoint()} points for {selectedGoal.GetName()}.");
        
    }

    public int ComputeTotalPoint()
    {
        int totalPoint = 0;
        foreach(Goal goal in goals)
        {
            
            totalPoint += goal.GetTotalPoint();

            
        }return totalPoint;
    }

    
    public void SaveToFile()
    {
        Console.WriteLine("File name (filename.txt) : ");
        string _filename = Console.ReadLine();
        File.WriteAllText(_filename, string.Empty);
        try
        {
            using (StreamWriter sw = new StreamWriter(_filename))
            {
                sw.WriteLine(ComputeTotalPoint());
                foreach (Goal goal in goals)
                {
                    if (goal is SimpleGoal)
                    {
                        SimpleGoal simpleGoal = (SimpleGoal)goal;
                        sw.WriteLine($"{goal.GetType()}|{simpleGoal.GetComplete()}|{simpleGoal.GetName()}|{simpleGoal.GetDescription()}|{simpleGoal.GetPoint()}");
                    }
                    if (goal is EternalGoal)
                    {
                        EternalGoal eternalGoal = (EternalGoal)goal;
                        sw.WriteLine($"{goal.GetType()}|{eternalGoal.GetComplete()}|{eternalGoal.GetName()}|{eternalGoal.GetDescription()}|{eternalGoal.GetPoint()}");
                    }
                    if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        sw.WriteLine($"{goal.GetType()}|{checklistGoal.GetComplete()}|{checklistGoal.GetName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetPoint()}{checklistGoal.GetHowMany()}|{checklistGoal.GetProgress()}|{checklistGoal.GetBonus()}");
                    }
                    
                }
            }    

        }
        catch
        {
            Console.WriteLine($"The file {_filename} does not exist.");
        }

            
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Goal saved to {_filename}.txt");
        Console.ForegroundColor = ConsoleColor.White;
            
        
    }

   

    public void LoadFromFile()
    {
        Console.WriteLine("Enter file name (filename.txt): ");
        string _filename = Console.ReadLine();
        if (File.Exists(_filename))
        {
            goals.Clear();
            using (StreamReader sr = new StreamReader(_filename))
            {
                string line;
                int lineCount = 0;
                int totalPoint = 0; 

                
                if ((line = sr.ReadLine()) != null)
                {
                    string[] totalPointData = line.Split('|');
                    if (totalPointData.Length >= 1) 
                    {
                        int.TryParse(totalPointData[0], out totalPoint); 
                    }
                }

                while ((line = sr.ReadLine()) != null)
                {
                    string[] goalData = line.Split('|');

                    if (goalData.Length >= 5) 
                    {
                        string goalType = goalData[0];
                        bool isComplete;
                        bool.TryParse(goalData[1], out isComplete);
                        string name = goalData[2];
                        string description = goalData[3];
                        int point = int.Parse(goalData[4]);

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                SimpleGoal simpleGoal = new SimpleGoal(isComplete, name, description, point);
                                goals.Add(simpleGoal);
                                break;
                            case "EternalGoal":
                                EternalGoal eternalGoal = new EternalGoal(isComplete, name, description, point);
                                goals.Add(eternalGoal);
                                break;
                            case "ChecklistGoal":
                                if (goalData.Length >= 8) 
                                {
                                    int howMany = int.Parse(goalData[5]);
                                    int progress = int.Parse(goalData[6]);
                                    int bonus = int.Parse(goalData[7]);
                                    ChecklistGoal checklistGoal = new ChecklistGoal(isComplete, name, description, point, howMany, progress, bonus);
                                    goals.Add(checklistGoal);
                                }
                                break;
                        }

                        lineCount++;
                    }
                }

               
                

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Goals loaded from {_filename}.txt");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        else
        {
            Console.WriteLine($"File {_filename}.txt not found.");
        }
    }




    

    
}