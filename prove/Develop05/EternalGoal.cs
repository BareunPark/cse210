public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
       
    }

    
    public override void RecordEvent()
    {
        
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