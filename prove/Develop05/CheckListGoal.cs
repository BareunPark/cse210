public class ChecklistGoal : Goal
{
    private int _howmany;
    private int _progress;
    private int _bonus;
    public ChecklistGoal()
    {
    }
    public ChecklistGoal(bool isComplete, string name, string description, int point, int howmany, int progress, int bonus) : base(isComplete, name, description, point)
    {
        _howmany = howmany;
        _progress = progress;
        _bonus = bonus;
    }

    public void SetHowMany(int howmany)
    {
        _howmany = howmany;
    }
    public int GetHowMany()
    {
        return _howmany;
    }
    public void SetPorgress()
    {
        _progress++;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }


    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.WriteLine("What is the description of this goal?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetPoint(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        SetHowMany(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        SetBonus(Convert.ToInt32(Console.ReadLine()));
    }
    public override void RecordEvent()
    {
        SetPorgress();
        SetTotalPoint(GetPoint());
        if (GetProgress() == GetHowMany())
        {
            SetComplete(true);
            
            SetTotalPoint(GetBonus());
        }
    }

    public override string PrintProgress()
    {
        if (GetComplete())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

}