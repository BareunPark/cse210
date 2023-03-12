public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    

    public override Goal CreateGoal()
    {
        Goal newGoal = base.CreateGoal();
        Goals.Add(newGoal);
        return newGoal;
    }
    

   
}