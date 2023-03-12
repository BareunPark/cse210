 public class EternalGoal : Goal
 {
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
       
    }

    
    public void CreateEternalGoal()
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

        EternalGoal eternalGoal = new EternalGoal(_goalName, _description, _point);
        _goals.Add(eternalGoal);
        
        
        Console.WriteLine("Eternal goal created successfully!");
    }

     public override void RecordEvent()
     {
        
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