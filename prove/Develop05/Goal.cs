public class Goal
{   
    
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public List<Goal> Goals { get; set; }

    public bool IsAchieved { get; set; } = false;
    public int TotalPoint = 0;

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        Goals = new List<Goal>();
    }

    

    
    public virtual Goal CreateGoal()
    {
        string _goalName = "";
        string _description = "";
        int _point = 0;
        
        

        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());

        Goal newGoal = new Goal(_goalName, _description, _point);
        Goals.Add(newGoal);
        return newGoal;
        
         
    }
    


    public void ListGoals()
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("You have no goals.");
            return;
        }

        Console.WriteLine("Your current goals are: ");
        for (int i = 0; i < Goals.Count; i ++)
        {
            string checkbox = Goals[i].IsAchieved ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {checkbox} {Goals[i].Name} - {Goals[i].Description} - {Goals[i].Points} points");
        }
    }
    

    public virtual void RecordEvent()
    {
        Console.WriteLine("Select a goal to update its progress:");
        for (int i = 0; i < Goals.Count; i++)
        {
            string checkbox = Goals[i].IsAchieved ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {Goals[i].Name} - {Goals[i].Description} - {Goals[i].Points} points");
        }

        int choice = -1;
        while (choice < 1 || choice > Goals.Count)
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
            if (choice < 1 || choice > Goals.Count)
            {
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {Goals.Count}.");
                continue;
            }
            if (Goals[choice - 1].IsAchieved)
            {
                Console.WriteLine("This goal is already achieved. Please select a different goal.");
                choice = -1;
            }
            else
            {
                break;
            }
        }

        Goal selectedGoal = Goals[choice - 1];
        Console.WriteLine($"You have earned {selectedGoal.Points} points for {selectedGoal.Name}.");
        Goals[choice - 1].IsAchieved = true;
        TotalPoint += selectedGoal.Points;
        
    }

    
   
}

