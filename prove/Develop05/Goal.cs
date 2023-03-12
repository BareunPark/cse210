public class Goal
{   
    
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public List<Goal> _goals = new List<Goal>();

    public bool IsAchieved { get; set; } = false;
    public int TotalPoint = 0;

    public Goal(string name, string description, int points, bool isAchieved = false)
    {
        Name = name;
        Description = description;
        Points = points;
        IsAchieved = isAchieved;

        _goals.Add(this);
        
    }

  

    

    
    // public virtual Goal CreateGoal()
    // {
        
        
         
    // }
    


    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals.");
            return;
        }

        Console.WriteLine("Your current goals are: ");
        for (int i = 0; i < _goals.Count; i ++)
        {
            string checkbox = _goals[i].IsAchieved ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {checkbox} {_goals[i].Name} - {_goals[i].Description} - {_goals[i].Points} points");
        }
    }
    

    public virtual void RecordEvent()
    {
        Console.WriteLine("Select a goal to update its progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox = _goals[i].IsAchieved ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {_goals[i].Name} - {_goals[i].Description} - {_goals[i].Points} points");
        }

        int choice = -1;
        while (choice < 1 || choice > _goals.Count)
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
            if (choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {_goals.Count}.");
                continue;
            }
            if (_goals[choice - 1].IsAchieved)
            {
                Console.WriteLine("This goal is already achieved. Please select a different goal.");
                choice = -1;
            }
            else
            {
                break;
            }
        }

        Goal selectedGoal = _goals[choice - 1];
        Console.WriteLine($"You have earned {selectedGoal.Points} points for {selectedGoal.Name}.");
        _goals[choice - 1].IsAchieved = true;
        TotalPoint += selectedGoal.Points;
        
    }

    
   
}

