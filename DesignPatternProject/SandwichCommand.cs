namespace DesignPatternProject;

public class SandwichCommand
{
    private List<Sandwich> _commandList;
    public List<Sandwich> CommandList
    {
        get => _commandList;
        set => _commandList = value;
    }
   
    public SandwichCommand()
    {
        _commandList = new List<Sandwich>();
    }


    public void AddSandwich(Sandwich sandwich)
    {
        this._commandList.Add(sandwich);
    }

    public void RemoveTheLastAddedSandwich()
    {
        this._commandList.RemoveAt(-1);
    }

    public bool IsCommandValid()
    {
        return _commandList.Count > 0;
    }

    public override string? ToString()
    {
        return _commandList.ToString();
    }
}