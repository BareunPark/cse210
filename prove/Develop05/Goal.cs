public abstract class Goal
{
    bool _isComplete;
    string _name;
    string _description;
    int _point;
    
    int _totalPoint;
    public Goal()
    {

    }

    public Goal(bool isComplete, string name, string description, int point)
    {
        _isComplete = isComplete;
        _name = name;
        _description = description;
        _point = point;
        // _totalPoint = totalPoint;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoint()
    {
        return _point;
    }

    
    public void SetPoint(int point)
    {
        _point = point;
    }
    public bool GetComplete()
    {
        return _isComplete;
    }
    public void SetComplete(bool X)
    {
        _isComplete = X;
    }
    public int GetTotalPoint()
    {
        return _totalPoint;
    }
    public void SetTotalPoint(int point)
    {
        _totalPoint = _totalPoint + point;
    }
    
    public abstract void CreateGoal();
    public abstract void RecordEvent();
    public abstract string PrintProgress();
}