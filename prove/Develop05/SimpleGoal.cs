public class SimpleGoal : Goal
{
    string _goalName = "";
    string _description = "";
    int _point = 0;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _goalName = name;
        _description = description;
        _point = points;
    }
    

    public void CreateSimpleGoal()
    {
        
        
        

        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());

        SimpleGoal simpleGoal = new SimpleGoal(_goalName, _description, _point);
        _goals.Add(simpleGoal);
        
        
        Console.WriteLine("Simple goal created successfully!");
    }
    

   
}