public class EternalGoal : Goal
{
    public EternalGoal()
    {
    }
    public EternalGoal(bool isComplete, string name, string description, int point) : base(isComplete, name, description, point)
    {

    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.WriteLine("What is the description of this goal?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetPoint(Convert.ToInt32(Console.ReadLine()));
    }
    public override void RecordEvent()
    {
        SetComplete(true);
        SetTotalPoint(GetPoint());
    }

    public override string PrintProgress()
    {
        if (GetComplete())
        {
            return "[ ]";
        }
        else
        {
            return "[ ]";
        }
    }

}