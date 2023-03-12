public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public static SimpleGoal CreateSimpleGoal(Goal _goals)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
        simpleGoal._goals.Add(simpleGoal);
        
        Console.WriteLine("Simple goal created successfully!");
        return simpleGoal;
    }
}