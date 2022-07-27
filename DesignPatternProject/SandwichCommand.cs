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

    public int SandwichOccurence(Sandwich occuredSandwich)
    {
        int occurence = 0;
        foreach(Sandwich sandwich in CommandList)
        {
            if (sandwich.Equals(occuredSandwich))
            {
                occurence += 1;
            }
        }
        return occurence;
    }

    public override string? ToString()
    {
        string commandListToString = "";
        foreach(Sandwich sandwich in _commandList)
        {
            
            commandListToString += sandwich.ToString() + "\n";
        }
        return commandListToString;
    }
}