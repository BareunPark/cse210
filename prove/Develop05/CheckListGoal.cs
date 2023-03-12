public class ChecklistGoal : Goal
{
    string _goalName = "";
    string _description = "";
    int _point = 0;
    int _numberoftimes = 0;
    int _bonus = 0;

    public ChecklistGoal(string name, string description, int points, int numberoftimes, int bonus) : base(name, description, points)
    {
        _goalName = name;
        _description = description;
        _point = points;
        _numberoftimes = numberoftimes;
        _bonus = bonus;
    }
    

    public void CreateChecklistGoal()
    {
        
        
        

        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _numberoftimes = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many time?");
        _bonus = int.Parse(Console.ReadLine());

        ChecklistGoal checklistGoal = new ChecklistGoal(_goalName, _description, _point, _numberoftimes, _bonus);
        _goals.Add(checklistGoal);
        
        
        Console.WriteLine("Check-list goal created successfully!");
    }
    

   
}